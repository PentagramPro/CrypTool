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
  public partial class ToolSHA : UserControl, ITool
  {
    public ToolSHA()
    {
      InitializeComponent();
    }

    public void ProcessData(byte[] data, out string result)
    {
      throw new NotImplementedException();
    }
  }
}
