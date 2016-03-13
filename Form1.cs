using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CrypTool.Tools;
using CryptCommon.Formats;
using CryptCommon.Interfaces;

namespace CrypTool
{
	public partial class Form1 : Form
	{
		private PluginLoader<ITool> tools;
		public Form1()
		{
			InitializeComponent();
			

			tools = new PluginLoader<ITool>();

			foreach (var tool in tools.Plugins)
			{
				TabPage tab = new TabPage();
				tab.Name = tool.GetName();
				tab.Text = tool.GetName();
				tab.Tag = tool;
				tab.Controls.Add(tool.GetControl());
				tool.GetControl().Dock = DockStyle.Fill;

				tabFunctions.TabPages.Add(tab);
			}

			dataType.Items.Add(new DataFormatHex());
			dataType.Items.Add(new DataFormatAscii());
			dataType.Items.Add(new DataFormatUnicode());

			resType.Items.Add(new DataFormatHex());
			resType.Items.Add(new DataFormatAscii());
			resType.Items.Add(new DataFormatUnicode());

            dataType.SelectedIndexChanged += DataFormatSelected;
		    resType.SelectedIndexChanged += DataFormatSelected;
			dataType.SelectedIndex = 0;
			resType.SelectedIndex = 0;
		}

        private void DataFormatSelected(object sender, EventArgs e)
        {
            txtData.DataFormat = dataType.SelectedItem as IDataFormat;
            //txtRes.DataFormat = resType.SelectedItem as IDataFormat;
        }

        private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				ITool tool = tabFunctions.SelectedTab.Tag as ITool;
				string result;
				byte[] src = txtData.GetTextAs((IDataFormat)dataType.SelectedItem);

				if (tool != null)
					tool.ProcessData(src, out result);
			}
			catch (Exception ex)
			{

				txtRes.Text = ex.ToString();
			}


		}




		/*
			void DO3DES()
			{
			  byte[] src = txtData.GetTextAs(GetDataFormat(dataType));
			  byte[] key = txt3DESKey.GetTextAs(DataFormat.Hex);
			  CipherMode mode = CipherMode.ECB;
			  switch (cmb3DESChaining.SelectedIndex)
			  {
				case 0:
				  mode = CipherMode.ECB; break;
				case 1:
				  mode = CipherMode.CBC; break;
			  }

			  bool encrypt = cmb3DESMode.SelectedIndex == 0;
			  byte[] res = StaticUtils.Encrypt3DES(src, key, mode, encrypt);
			  txtRes.Text = StaticUtils.ByteArrayToString(res);

			}*/

		
	}
}
