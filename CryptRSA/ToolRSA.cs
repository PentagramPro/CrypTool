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
using CryptCommon.Interfaces;
using CryptRSA;
using CryptCommon.Formats;

namespace CrypTool.Tools
{
	public partial class ToolRSA : UserControl, ITool
	{
		RsaSettings settings = new RsaSettings();
		RsaLogic logic = new RsaLogic();

		public ToolRSA()
		{
			InitializeComponent();
			txtRsaExp.DataFormat = new DataFormatHex();
			txtRsaKey.DataFormat = new DataFormatHex();

			txtRsaKey.Validated += UpdateSettings;
			txtRsaExp.Validated += UpdateSettings;
		}

	    public void InitTool(string pathToConfig)
	    {
	        settings = Settings.Deserialize<RsaSettings>(pathToConfig);
            txtRsaKey.Text = Utils.ArrayToString(settings.Modulus);
            txtRsaExp.Text = Utils.ArrayToString(settings.Exponent);
        }

	    void UpdateSettings(object sender, EventArgs args)
		{
			settings.Modulus = txtRsaKey.ToDataFormat();
			settings.Exponent = txtRsaExp.ToDataFormat();
		}
		public void ProcessData(byte[] data, out string result)
		{
			result = Utils.ArrayToString(logic.Encrypt(data, settings));
		}

		public string GetName()
		{
			return "Direct RSA";
		}

		public Control GetControl()
		{
			return this;
		}

		
	}
}
