using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptCommon;

namespace CrypTool
{
  enum DataFormat
  {
    Hex, Ascii, Unicode
  }
  class TextCube : TextBox
  {
    public byte[] GetTextAs(DataFormat format)
    {
      byte[] res = null;
      switch (format)
      {
        case DataFormat.Hex:
          res = StaticUtils.StringToByteArrayFastest(Text);
          break;
        case DataFormat.Ascii:
          res = Encoding.ASCII.GetBytes(Text);
          break;
        case DataFormat.Unicode:
          res = Encoding.Unicode.GetBytes(Text);
          break;
      }
      return res;
    }
  }
}
