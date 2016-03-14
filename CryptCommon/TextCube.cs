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
	    private Color colorEmpty = Color.White;
	    private Color colorError = Color.LightCoral;
	    private Color colorOk = Color.PaleGreen;
	    public IDataFormat DataFormat {get;set;}

	    // [PropertyTab("IsNumaric")]
	    [DisplayName("Color Empty")]
	    [Category("Appearance")]
	    public Color ColorEmpty
	    {
	        get { return colorEmpty; }
	        set { colorEmpty = value; Invalidate(); }
	    }

	    [DisplayName("Color Error")]
	    [Category("Appearance")]
	    public Color ColorError
	    {
	        get { return colorError; }
	        set { colorError = value; Invalidate();}
	    }

	    [DisplayName("Color Ok")]
	    [Category("Appearance")]
	    public Color ColorOk
	    {
	        get { return colorOk; }
	        set { colorOk = value; Invalidate(); }
	    }

	    private Label errorMessage;
	    protected override void InitLayout()
		{
            
			base.InitLayout();
			Validating += TextCube_Validating;
            errorMessage = new Label();
            Controls.Add(errorMessage);
	        errorMessage.Visible = false;
	        errorMessage.BackColor = Color.LavenderBlush;
            errorMessage.AutoSize = true;
        }

	    void ShowError(string text)
	    {
	        errorMessage.Text = text;
	        errorMessage.Visible = true;
	        
            errorMessage.Location = new Point((Size.Width-errorMessage.Size.Width)/2,
                (Size.Height - errorMessage.Size.Height) / 2);
	    }

	    void HideError()
	    {
	        errorMessage.Visible = false;
	    }

		private void TextCube_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (DataFormat == null)
				return;

		    if (Text.Length == 0)
		    {
		        BackColor = ColorEmpty;
                HideError();
		    }
		    else
		    {
			    try
			    {
				    DataFormat.ParseString(Text);
			        BackColor = ColorOk;
                    HideError();
			    }
			    catch(DataFormatException ex)
			    {
			        BackColor = ColorError;
                    ShowError(ex.Message);
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
