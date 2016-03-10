using System;
using System.Collections.Generic;
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

		protected override void InitLayout()
		{
			base.InitLayout();
			Validating += TextCube_Validating;
		}

		private void TextCube_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (DataFormat == null)
				return;
			try
			{
				DataFormat.ParseString(Text);
			}
			catch(DataFormatException ex)
			{
				e.Cancel = true;
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
