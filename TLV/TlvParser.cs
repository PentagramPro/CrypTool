using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace IvanListener
{
  public enum TLVClassType
  {
    Unknown = 0,
    UniversalClass,
    ApplicationClass,
    ContextSpecificClass,
    PrivateClass
  }

  public enum TLVDataObjectType
  {
    Unknown = 0,
    PrimitiveDataObject,
    ConstructedDataObject
  }

  public class TlvParseException : Exception
  {
    public int Location;
    public string ProblematicTag;

    public TlvParseException(string message, int location, string problematicTag) : base(message)
    {
      Location = location;
      ProblematicTag = problematicTag;
    }

    public TlvParseException(string message, int location) : base(message)
    {
      Location = location;
    }

    public override string ToString()
    {
      return string.Format("Tlv parser error: '{0}' at pos {1} at tag [{2}] ", Message, Location, ProblematicTag);
    }
  }


  public class ParseFixes
  {
    public bool TreatFFAsPrimitive = false;
    
  }

  public class ByteList : List<byte>
  {
      
  };

  public class InvalidDataException : Exception
  {
    public InvalidDataException(string message) : base(message)
    {
    }
  };

  public class TLVDataSorter : IComparer<TLVData>
  {
    public int Compare(TLVData p1, TLVData p2)
    {
      int res = p1.Tag.Length.CompareTo(p2.Tag.Length);
      if (res == 0)
      {
        for (int i = 0; i < p1.Tag.Length; i++)
        {
          res = p1.Tag[i].CompareTo(p2.Tag[i]);
          if (res != 0)
            break;
        }
      }
      return res;
    }
  }

  /// <summary>
  /// Represents a BER-TLV data object
  /// </summary>
  /// <remarks>
  /// TLV's define data in a Tag-Length-Value structure
  /// The Tag-name and lengths may be defined by multiple bytes, certain bit-masking defines how many etc.
  /// </remarks>
  public abstract class TLVData
  {
    //private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    private static readonly byte APPLICATION_CLASS_MASK = 0x40;          // 0100 0000
    private static readonly byte CONTEXT_SPECIFIC_CLASS_MASK = 0x80;     // 1000 0000
    private static readonly byte PRIVATE_CLASS_MASK = 0xC0;              // 1100 0000
    private static readonly byte CONSTRUCTED_DATAOBJECT_MASK = 0x20;     // 0010 0000
    private static readonly byte MULTI_BYTE_TAG_MASK = 0x1F;             // 0001 1111    (For first tag-byte)
    private static readonly byte MULTI_BYTE_TAG_2_MASK = 0x80;           // 1000 0000    (For subsequent tag-bytes)

    private static readonly byte MULTI_BYTE_LENGTH_MASK = 0x80;          // 1000 0000    
    private static readonly byte SINGLE_BYTE_LENGTH_MASK = 0x7F;         // 0111 1111    

    private static object logLock = new object();
    static List<string> StringTags = new List<string>() {"DF62", "DF66","DF67","DF70","DF72","DF73"}; 

    public TLVClassType ClassType { get; set; }
    public TLVDataObjectType DataObjectType { get; set; }
    public byte[] Tag { get; set; }
    public string TagName
    {
      get
      {
        if (Tag == null)
          return "none";

        StringBuilder sb = new StringBuilder();
        foreach (byte b in Tag)
        {
          sb.Append(b.ToString("X2"));
        }
        return sb.ToString();
      }
    }
    public int Length { get; set; }
    public byte[] Value { get; set; }


    protected void ParseSingle(byte[] data,ParseFixes fixes)
    {
      int offset = 0;
      Parse(data, ref offset,fixes);
    }

    void BytesToString(StringBuilder sb, byte[] data)
    {
      foreach (var b in data)
      {
        sb.AppendFormat("{0:X2}", b);
      }
      
    }
    public virtual void BuildString(StringBuilder sb, string ind)
    {
      sb.Append(ind);
      sb.Append("[");
      BytesToString(sb, Tag);
      sb.Append("] ");
      if (DataObjectType == TLVDataObjectType.PrimitiveDataObject)
      {
        if (StringTags.Contains(TagName))
          sb.Append(Encoding.ASCII.GetString(Value).Trim('\0'));
        else
          BytesToString(sb, Value);
      }
      sb.AppendLine();
    }

    /// <summary>
    /// Parses out a TLV assuming that the byte at (zero-based) index 'offset' of the array passed in is the first byte of the tag
    /// </summary>
    /// <returns>The index of the byte-array where the tag stops, -1 if the end of the data has been reached</returns>
    public int Parse(byte[] data, ref int offset, ParseFixes fixes)
    {
      // Get class:
      ClassType = GetClassType(data[offset]);

      // Get the data-object type
      DataObjectType = GetDataObjectType(data[offset]);

      // Parse Tag
      byte[] tag = GetTag(data, ref offset,2);
      Tag = new byte[tag.Length];
      Array.Copy(tag, Tag, tag.Length);

      // fix for 0xFFFX tags
      if(fixes.TreatFFAsPrimitive && tag.Length==2 && tag[0]==0xff)
        DataObjectType = TLVDataObjectType.PrimitiveDataObject;
      

      if (offset >= data.Length)
        throw new TlvParseException("No length/data for TLV tag",offset,TagName);
      try
      {
        // Parse the length
        Length = GetLength(data, ref offset);
      }
      catch (Exception ex)
      {
        throw new TlvParseException("Cannot read length",offset,TagName);
      }
      // Parse the data
      if (Length > (data.Length - offset))
      {
        throw new TlvParseException(
            String.Format("Insufficient data for TLV tag. Tag={0}, Length={1}, available={2}",
            BitConverter.ToString(Tag, 0), Length, data.Length - offset),offset,TagName);
      }

      Value = new byte[Length];
      Array.Copy(data, offset, Value, 0, Length);
      offset += Length;

      if (offset >= data.Length)
      {
        offset = -1;
      }

      return offset;
    }



    public static List<TLVTag> ParseTags(byte[] data, ParseFixes fixes)
    {
      List<TLVTag> tags = new List<TLVTag>();
      int offset = 0;
      while (offset >= 0)
      {
        TLVTag tag = new TLVTag();
        tag.Parse(data, ref offset,fixes);
        tags.Add(tag);
      }

      return tags;
    }

    public byte[] Serialize()
    {
      ByteList tagContents = new ByteList();

      tagContents.AddRange(Tag);
      tagContents.AddRange(CreateBERTLVLengthBytes(Value));
      tagContents.AddRange(Value);

      return tagContents.ToArray();
    }

    public static byte[] CreateBERTLVLengthBytes(byte[] data)
    {
      byte[] lenBytes = GetBytesFromInt(data.Length);

      if (data.Length <= 127)
        return lenBytes;

      // Add the first byte indicating the number of bytes in the length-bytes to follow, masked with 0x80
      byte[] tlvLenBytes = new byte[lenBytes.Length + 1];
      tlvLenBytes[0] = (byte)(((byte)lenBytes.Length) | (byte)MULTI_BYTE_LENGTH_MASK);
      Array.Copy(lenBytes, 0, tlvLenBytes, 1, lenBytes.Length);

      return tlvLenBytes;
    }

    public static byte[] GetBytesFromInt(int value)
    {
      string s = value.ToString("X2");
      int numBytes = (int)Math.Ceiling((double)(s.Length / 2f));

      byte[] paddedBytes = BitConverter.GetBytes(value);
      if (BitConverter.IsLittleEndian)
      {
        Array.Reverse(paddedBytes);
      }
      byte[] result = new byte[numBytes];
      Array.Copy(paddedBytes, paddedBytes.Length - numBytes, result, 0, numBytes);
      return result;
    }

    /// <summary>
    /// Get the TLV Tag from the supplied byte-array starting at the supplied offset.
    /// </summary>
    private static byte[] GetTag(byte[] data, ref int offset, int maxLen = 10)
    {
      // Parse the Tag
      // 1st tag-byte
      ByteList tag = new ByteList();
      bool isNextByteTag = false;
      tag.Add(data[offset]);
      if ((data[offset] & MULTI_BYTE_TAG_MASK) == MULTI_BYTE_TAG_MASK)
        isNextByteTag = true;


      offset++;

      // Subsequent tag-bytes
      while (isNextByteTag && offset < data.Length && tag.Count<maxLen)
      {
        if ((data[offset] & MULTI_BYTE_TAG_2_MASK) != MULTI_BYTE_TAG_2_MASK)
          isNextByteTag = false;


        tag.Add(data[offset]);

        offset++;
      }

      return tag.ToArray();
    }

    /// <summary>
    /// Get the TLV Length from the supplied byte-array starting at the supplied offset.
    /// </summary>
    private static int GetLength(byte[] data, ref int offset)
    {
      int len = (int)(data[offset] & SINGLE_BYTE_LENGTH_MASK);
      if ((data[offset] & MULTI_BYTE_LENGTH_MASK) == MULTI_BYTE_LENGTH_MASK)
      {
        ByteList lenBytes = new ByteList();
        // Multi-byte-length
        offset++;
        for (int i = 0; i < len; i++)
        {
          lenBytes.Add(data[offset]);
          offset++;
        }

        lenBytes.ToArray();
        if (BitConverter.IsLittleEndian)
        {
          lenBytes.Reverse();
        }
        int size = lenBytes.Count;
        byte[] paddedLengthBytes = new byte[4]; //BitConverter requires 4 bytes
        for (int j = 0; j < 4 - size; j++)
        {
          lenBytes.Add(0);
        }

        paddedLengthBytes = lenBytes.ToArray();
        len = BitConverter.ToInt32(paddedLengthBytes, 0);
      }
      else
      {
        offset++;
      }

      return len;
    }

    private static TLVClassType GetClassType(byte tag)
    {
      TLVClassType type = TLVClassType.Unknown;

      if ((tag & APPLICATION_CLASS_MASK) == APPLICATION_CLASS_MASK)
      {
        type = TLVClassType.ApplicationClass;
      }
      else if ((tag & CONTEXT_SPECIFIC_CLASS_MASK) == CONTEXT_SPECIFIC_CLASS_MASK)
      {
        type = TLVClassType.ApplicationClass;
      }
      else if ((tag & PRIVATE_CLASS_MASK) == PRIVATE_CLASS_MASK)
      {
        type = TLVClassType.PrivateClass;
      }
      else
      {
        type = TLVClassType.UniversalClass;
      }

      return type;
    }

    private static TLVDataObjectType GetDataObjectType(byte tag)
    {
      TLVDataObjectType type = TLVDataObjectType.Unknown;
      if ((tag & CONSTRUCTED_DATAOBJECT_MASK) == CONSTRUCTED_DATAOBJECT_MASK)
      {
        type = TLVDataObjectType.ConstructedDataObject;
      }
      else
      {
        type = TLVDataObjectType.PrimitiveDataObject;
      }

      return type;
    }
  }


  public class TLVTemplate : TLVData
  {
    public List<TLVTemplate> ChildTemplates { get; set; }
    public List<TLVTag> Tags { get; set; }

    public TLVTemplate()
      : base()
    {
      ChildTemplates = new List<TLVTemplate>();
      Tags = new List<TLVTag>();
    }

    /// <summary>
    /// Parses out a TLVTemplate object from the supplied data. This recursively parses any 'nested' templates and tags from the data-portion
    /// </summary>
    /// <remarks>
    /// The full data supplied may or may not be used, as only the first TLV object is parsed out
    /// </remarks>
    public static List<TLVTemplate> ParseAll(byte[] data, ParseFixes fixes, out TlvParseException lastEx)
    {
      List<TLVTemplate> templates = new List<TLVTemplate>();
      lastEx = null;
      int valueOffset = 0;
      while (valueOffset < data.Length && valueOffset != -1)
      {
        TLVTemplate tlvTemplate = new TLVTemplate();

        try
        {
          tlvTemplate.Parse(data, ref valueOffset, fixes);

          if (tlvTemplate.DataObjectType == TLVDataObjectType.ConstructedDataObject)
          {
            tlvTemplate.ChildTemplates = TLVTemplate.ParseAll(tlvTemplate.Value, fixes, out lastEx);
            tlvTemplate.ChildTemplates.Sort(new TLVDataSorter());
          }
        }
        catch (TlvParseException ex)
        {
          lastEx = ex;
          break;
        }

        if (lastEx != null)
          break;

        templates.Add(tlvTemplate);
      }

      return templates;
    }

    public static TLVTemplate Create(byte[] templateName, List<TLVTag> tags)
    {
      TLVTemplate template = new TLVTemplate();
      template.Tag = templateName;
      template.Tags = tags;
      return template;
    }

    public new byte[] Serialize()
    {
      ByteList templateData = new ByteList();

      ByteList tagData = new ByteList();
      foreach (TLVTag tag in Tags)
      {
        tagData.AddRange(tag.Serialize());
      }

      Value = tagData.ToArray();

      return base.Serialize();
    }


    public override void BuildString(StringBuilder sb, string ind)
    {
      
      base.BuildString(sb,ind);

      ind += "  ";
      foreach (TLVTemplate tag in ChildTemplates)
      {
        tag.BuildString(sb,ind);
      }
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
     
      BuildString(sb,"");

      return sb.ToString();
    }
  }


  public class TLVTag : TLVData
  {
    /// <summary>
    /// Parses out a single TLVData object from the supplied data
    /// </summary>
    /// <remarks>
    /// The full data supplied may or may not be used, as only the first TLV object is parsed out
    /// </remarks>
    public static TLVTag Parse(byte[] data,ParseFixes fixes)
    {
      TLVTag tlvData = new TLVTag();
      tlvData.ParseSingle(data,fixes);
      return tlvData;
    }

    public static List<TLVTag> ParseAll(byte[] data, ParseFixes fixes)
    {
      List<TLVTag> tags = new List<TLVTag>();
      int offset = 0;
      while (offset >= 0)
      {
        TLVTag tag = new TLVTag();
        tag.Parse(data, ref offset,fixes);
        tags.Add(tag);
      }

      return tags;
    }

    /// <summary>
    /// Create a TLV tag 
    /// </summary>
    /// <param name="tag">The tag name</param>
    /// <param name="data">The tag data</param>
    public static TLVTag Create(byte[] tagName, byte[] data)
    {
      TLVTag tag = new TLVTag();
      tag.Tag = tagName;
      tag.DataObjectType = TLVDataObjectType.PrimitiveDataObject;
      tag.Value = data;

      return tag;
    }

    

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Tag:       " + BitConverter.ToString(Tag));
      sb.AppendLine("Length:    " + Length.ToString());
      sb.AppendLine("Value(raw):" + BitConverter.ToString(Value));
      sb.AppendLine("Value:     " + Encoding.ASCII.GetString(Value).Replace("\a", "|"));

      return sb.ToString();
    }
  }
}
