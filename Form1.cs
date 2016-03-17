using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CryptCommon;
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
            string configsFolder = Path.Combine(Application.StartupPath, "./configs");

            foreach (var tool in tools.Plugins)
			{
				TabPage tab = new TabPage();
				tab.Name = tool.GetName();
				tab.Text = tool.GetName();
				tab.Tag = tool;
				tab.Controls.Add(tool.GetControl());
				tool.GetControl().Dock = DockStyle.Fill;

				tabFunctions.TabPages.Add(tab);

			    string path = Path.Combine(configsFolder,"tool." + tool.GetName() + ".conf");
                tool.InitTool(path);
			}

			dataType.AddItem(new DataFormatHex());
			dataType.AddItem(new DataFormatAscii());
			dataType.AddItem(new DataFormatUnicode());

			resType.AddItem(new DataFormatHex());
			resType.AddItem(new DataFormatAscii());
			resType.AddItem(new DataFormatUnicode());

            dataType.SelectedIndexChanged += DataFormatSelected;
		    resType.SelectedIndexChanged += DataFormatSelected;
			dataType.SelectedIndex = 0;
			resType.SelectedIndex = 0;

		    

		}

        private void DataFormatSelected(object sender, EventArgs e)
        {
            txtData.DataFormat = dataType.EasySelectedObject;
            //txtRes.DataFormat = resType.SelectedItem as IDataFormat;
        }

        private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				ITool tool = tabFunctions.SelectedTab.Tag as ITool;
			    byte[] src = txtData.GetTextAs(dataType.EasySelectedObject);

			    if (tool != null)
			    {
			        string result;
			        tool.ProcessData(src, out result);
			        txtRes.Text = result;
			    }
			}
			catch (Exception ex)
			{

				txtRes.Text = ex.ToString();
			}


		}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var tool in tools.Plugins)
            {
                
            }
        }
    }

    public class DataFormatCombo : EasyCombo<IDataFormat>
    {
    }
}
