using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrypTool.Tools
{
  public partial class Tool3DES : UserControl, ITool
  {
    public Tool3DES()
    {
      InitializeComponent();
      cmb3DESChaining.SelectedIndex = 0;
      cmb3DESMode.SelectedIndex = 0;
    }

    public void ProcessData(byte[] data, out string result)
    {
      throw new NotImplementedException();
    }

    public string GetName()
    {
      return "3DES";
    }

    public Control GetControl()
    {
      return this;
    }
  }
}
