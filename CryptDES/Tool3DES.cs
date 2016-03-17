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
using CryptCommon.Formats;
using CryptCommon.Interfaces;
using CryptDES;

namespace CrypTool.Tools
{
    public partial class Tool3DES : UserControl, ITool
    {
        private DesSettings settings = new DesSettings();
        DesLogic logic = new DesLogic();

        
        public Tool3DES()
        {
            InitializeComponent();
            cmb3DESChaining.AddItem("ECB", CipherMode.ECB);
            cmb3DESChaining.AddItem("CBC", CipherMode.CBC);

            cmb3DESMode.AddItem("Encrypt",true);
            cmb3DESMode.AddItem("Decrypt", false);

            cmb3DESChaining.SelectedIndex = 0;
            cmb3DESMode.SelectedIndex = 0;

            txt3DESKey.DataFormat = new DataFormatHex(16);

            cmb3DESChaining.SelectedIndexChanged += (sender, args) => UpdateSettings();
            cmb3DESMode.SelectedIndexChanged += (sender, args) => UpdateSettings();
            txt3DESKey.Validated += (sender, args) => UpdateSettings();
        }

        public void InitTool(string pathToConfig)
        {
            settings = Settings.Deserialize<DesSettings>(pathToConfig);
            cmb3DESChaining.EasySelectedObject = settings.Mode;
            cmb3DESMode.EasySelectedObject = settings.Encrypt;
            txt3DESKey.Text = Utils.ArrayToString(settings.Key);
        }

        public void ProcessData(byte[] data, out string result)
        {
            byte[] res = logic.Encrypt(data, settings);
            result = Utils.ArrayToString(res);
        }

        void UpdateSettings()
        {
            settings.Encrypt = (bool) cmb3DESMode.EasySelectedObject;
            settings.Key = txt3DESKey.ToDataFormat();
            settings.Mode = (CipherMode) cmb3DESChaining.EasySelectedObject;
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

    public class BooleanCombo : EasyCombo<bool>{}

    public class CipherCombo : EasyCombo<CipherMode> { }
}
