using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using IvanListener;

namespace CrypTool
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      dataType.SelectedIndex=0;
      resType.SelectedIndex = 0;
      cmb3DESChaining.SelectedIndex = 0;
      cmb3DESMode.SelectedIndex = 0;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (tabFunctions.SelectedTab == tabRsa)
          DoRSA();
        else if (tabFunctions.SelectedTab == tabSha1)
          DoSHA1();
        else if (tabFunctions.SelectedTab == tab3DES)
          DO3DES();
        else if(tabFunctions.SelectedTab==tabTLV)
          DoTLV();
      }
      catch (System.Exception ex)
      {
        txtRes.Text = ex.ToString();
      }
      
    }

    public class VivoGroup
    {
      public List<TLVTemplate> tlvs = new List<TLVTemplate>();
      public int GroupIndex = 0;

      public void BuildString(StringBuilder sb)
      {
        sb.AppendFormat("Group {0}\r\n", GroupIndex);
        foreach (var t in tlvs)
        {
          sb.Append(t);
        }
      }
    }
    void DoTLV()
    {
      
      byte[] src = txtData.GetTextAs(GetDataFormat(dataType));
      StringBuilder sb = new StringBuilder();
      List<TLVTemplate> tlv = new List<TLVTemplate>();
      TlvParseException lastEx = null;
    
      tlv = TLVTemplate.ParseAll(src, new ParseFixes() {TreatFFAsPrimitive = chkViVO.Checked},out lastEx);
        
      PrintParsedTlv(tlv, sb);
      if (lastEx != null)
      {
      
        sb.Append(lastEx);
      }
      

      
      txtRes.Text = sb.ToString();

      

    }

    private void PrintParsedTlv(List<TLVTemplate> tlv, StringBuilder sb)
    {
      if (chkViVO.Checked)
      {
        List<VivoGroup> groups = new List<VivoGroup>();
        VivoGroup g = null;
        foreach (var t in tlv)
        {
          if (t.TagName == "FFE4")
          {
            g = new VivoGroup {GroupIndex = t.Value[0]};
            groups.Add(g);
          }
          else if (g != null)
          {
            g.tlvs.Add(t);
          }
        }

        foreach (var group in groups)
        {
          group.tlvs.Sort(new TLVDataSorter());
          group.BuildString(sb);
        }
      }
      else
      {
        tlv.Sort(new TLVDataSorter());
        foreach (var t in tlv)
        {
          sb.Append(t);
        }
      }
    }


    void DoRSA()
    {
      byte[] src = txtData.GetTextAs(GetDataFormat(dataType));
      byte[] mod = txtRsaKey.GetTextAs(DataFormat.Hex);
      byte[] exp = txtRsaExp.GetTextAs(DataFormat.Hex);



      string res = StaticUtils.ByteArrayToString(StaticUtils.EncryptRSA(src, mod, exp));
      txtRes.Text = res;
    }

    void DoSHA1()
    {
      
    }

    void DO3DES()
    {
      byte[] src = txtData.GetTextAs(GetDataFormat(dataType));
      byte[] key = txt3DESKey.GetTextAs(DataFormat.Hex);
      CipherMode mode = CipherMode.ECB;
      switch (cmb3DESChaining.SelectedIndex)
      {
        case 0:
          mode = CipherMode.ECB; break;
        case 1:
          mode = CipherMode.CBC; break;
      }

      bool encrypt = cmb3DESMode.SelectedIndex == 0;
      byte[] res = StaticUtils.Encrypt3DES(src, key, mode, encrypt);
      txtRes.Text = StaticUtils.ByteArrayToString(res);

    }

    DataFormat GetDataFormat(ComboBox combo)
    {
      switch (combo.SelectedIndex)
      {
        case 0:
          return DataFormat.Hex;
        case 1:
          return DataFormat.Ascii;
        case 2:
          return DataFormat.Unicode;
      }
      return DataFormat.Ascii;
    }
  }
}
