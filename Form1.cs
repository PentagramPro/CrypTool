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
        private string configsFolder;


        public Form1()
		{
			InitializeComponent();
			

			tools = new PluginLoader<ITool>();
            configsFolder = Path.Combine(Application.StartupPath, "./configs");

            try
            {
                Directory.CreateDirectory(configsFolder);
            }
            catch(Exception e) { }

            foreach (var tool in tools.Plugins)
			{
				TabPage tab = new TabPage();
				tab.Name = tool.GetName();
				tab.Text = tool.GetName();
				tab.Tag = tool;
				tab.Controls.Add(tool.GetControl());
				tool.GetControl().Dock = DockStyle.Fill;

				tabFunctions.TabPages.Add(tab);

                tool.InitTool(CombineConfigPath(tool.GetName()));
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

        string CombineConfigPath(string toolName)
        {
            return Path.Combine(configsFolder, "tool." + toolName + ".conf");
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
                tool.DeinitTool(CombineConfigPath(tool.GetName()));
            }
        }
    }

    public class DataFormatCombo : EasyCombo<IDataFormat>
    {
    }
}
