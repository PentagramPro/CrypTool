using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptCommon;
using CrypTool.Tools;
using CryptCommon.Interfaces;

namespace CryptHashes
{
    public partial class HashCalc : UserControl, ITool
    {


        public HashCalc()
        {
            InitializeComponent();
            cmbHashType.AddItem("MD5", MD5.Create());
            cmbHashType.AddItem("SHA1", SHA1.Create());
            cmbHashType.SelectedIndex = 0;
        }

        public void InitTool(string pathToConfig)
        {
            
        }

        public void ProcessData(byte[] data, out string result)
        {
            result = Utils.ArrayToString(cmbHashType.EasySelectedObject.ComputeHash(data));
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

    public class EasyComboHash : EasyCombo<HashAlgorithm>
    {
        
    }
}
