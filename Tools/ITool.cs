using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypTool.Tools
{
  public interface ITool
  {
    void ProcessData(byte[] data, out string result);
  }
}
