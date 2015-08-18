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
using IvanListener;

namespace CrypTool
{
  public partial class Form1 : Form
  {
    private PluginLoader<ITool> tools; 
    public Form1()
    {
      InitializeComponent();
      dataType.SelectedIndex=0;
      resType.SelectedIndex = 0;
      
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
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      try
      {
        ITool tool = tabFunctions.SelectedTab.Tag as ITool;
        string result;
        byte[] src = txtData.GetTextAs(GetDataFormat(dataType));

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

    DataFormat GetDataFormat(ComboBox combo)
    {
      switch (combo.SelectedIndex)
      {
        case 0:
          return DataFormat.Hex;
        case 1:
          return DataFormat.Ascii;
        case 2:
          return DataFormat.Unicode;
      }
      return DataFormat.Ascii;
    }
  }
}
