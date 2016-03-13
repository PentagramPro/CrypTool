using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptCommon;
using CryptCommon.Interfaces;
using CryptCommon.Excptions;

namespace CrypTool
{

	public class TextCube : TextBox
	{
		public IDataFormat DataFormat {get;set;}

       // [PropertyTab("IsNumaric")]
        [DisplayName("Color Empty")]
        [Category("Appearance")]
        public Color ColorEmpty { get; set; }

        [DisplayName("Color Error")]
        [Category("Appearance")]
        public Color ColorError { get; set; }

        [DisplayName("Color Ok")]
        [Category("Appearance")]
        public Color ColorOk { get; set; }

        protected override void InitLayout()
		{
			base.InitLayout();
			Validating += TextCube_Validating;
		}

		private void TextCube_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (DataFormat == null)
				return;

		    if (Text.Length == 0)
		    {
		        BackColor = ColorEmpty;
		    }
		    else
		    {
			    try
			    {
				    DataFormat.ParseString(Text);
			        BackColor = ColorOk;
			    }
			    catch(DataFormatException ex)
			    {
			        BackColor = ColorError;
			    }
		    }

		}

		public byte[] ToDataFormat()
		{
			if (DataFormat == null)
				throw new DataFormatException("You cannot use ToDataFormat() if DataFormat property is null");
			return DataFormat.ParseString(Text);
		}
		
		public byte[] GetTextAs(IDataFormat format)
		{
			try
			{
				return format.ParseString(Text);
			}
			catch(DataFormatException e)
			{
				return new byte[0];
			}
		}
	}
}
