using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptCommon;

namespace CrypTool.Tools
{
  public partial class ToolRSA : UserControl, ITool
  {
    public ToolRSA()
    {
      InitializeComponent();
    }

    public void ProcessData(byte[] data, out string result)
    {
      byte[] mod = txtRsaKey.GetTextAs(DataFormat.Hex);
      byte[] exp = txtRsaExp.GetTextAs(DataFormat.Hex);



      string res = StaticUtils.ByteArrayToString(StaticUtils.EncryptRSA(data, mod, exp));
      result = res;
    }

    public string GetName()
    {
      return "RSA";
    }

    public Control GetControl()
    {
      return this;
    }
  }
}
