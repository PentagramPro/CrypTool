using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrypTool.Tools
{
    public interface ITool
    {
        void InitTool(string pathToConfig);
        void DeinitTool(string pathToConfig);
        void ProcessData(byte[] data, out string result);

        string GetName();
        Control GetControl();
    }
}
