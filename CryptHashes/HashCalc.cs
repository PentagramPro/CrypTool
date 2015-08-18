using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrypTool.Tools;

namespace CryptHashes
{
  public partial class HashCalc : UserControl, ITool
  {
    public HashCalc()
    {
      InitializeComponent();
    }

    public void ProcessData(byte[] data, out string result)
    {
      throw new NotImplementedException();
    }

    public string GetName()
    {
      return "Hashes";
    }

    public Control GetControl()
    {
      return this;
    }
  }
}
