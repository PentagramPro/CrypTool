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

		public ISettings Settings
		{
			get
			{ 
				return settings;
			}
			set
			{

				settings = value as RsaSettings;
				txtRsaKey.Text = StaticUtils.ByteArrayToString(settings.Modulus);
				txtRsaExp.Text = StaticUtils.ByteArrayToString(settings.Exponent);
			}
		}


		public ToolRSA()
		{
			InitializeComponent();
			txtRsaExp.DataFormat = new DataFormatHex();
			txtRsaKey.DataFormat = new DataFormatHex();

			txtRsaKey.Validated += UpdateSettings;
			txtRsaExp.Validated += UpdateSettings;
		}

		void UpdateSettings(object sender, EventArgs args)
		{
			settings.Modulus = txtRsaKey.ToDataFormat();
			settings.Exponent = txtRsaExp.ToDataFormat();
		}
		public void ProcessData(byte[] data, out string result)
		{
			string res = StaticUtils.ByteArrayToString(logic.Encrypt(data, settings));
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
