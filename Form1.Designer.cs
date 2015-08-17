﻿using CrypTool.Tools;

namespace CrypTool
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dataType = new System.Windows.Forms.ComboBox();
      this.resType = new System.Windows.Forms.ComboBox();
      this.tabFunctions = new System.Windows.Forms.TabControl();
      this.tabRsa = new System.Windows.Forms.TabPage();
      this.panel1 = new CrypTool.Tools.ToolRSA();
      this.tab3DES = new System.Windows.Forms.TabPage();
      this.tool3DES1 = new CrypTool.Tools.Tool3DES();
      this.tabTLV = new System.Windows.Forms.TabPage();
      this.toolTLV1 = new CrypTool.Tools.ToolTLV();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.button1 = new System.Windows.Forms.Button();
      this.txtData = new CrypTool.TextCube();
      this.txtRes = new CrypTool.TextCube();
      this.tabFunctions.SuspendLayout();
      this.tabRsa.SuspendLayout();
      this.tab3DES.SuspendLayout();
      this.tabTLV.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Data";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Result";
      // 
      // dataType
      // 
      this.dataType.FormattingEnabled = true;
      this.dataType.Items.AddRange(new object[] {
            "HEX",
            "ASCII",
            "UNICODE"});
      this.dataType.Location = new System.Drawing.Point(12, 35);
      this.dataType.Name = "dataType";
      this.dataType.Size = new System.Drawing.Size(69, 21);
      this.dataType.TabIndex = 4;
      // 
      // resType
      // 
      this.resType.FormattingEnabled = true;
      this.resType.Items.AddRange(new object[] {
            "HEX",
            "ASCII",
            "UNICODE"});
      this.resType.Location = new System.Drawing.Point(12, 106);
      this.resType.Name = "resType";
      this.resType.Size = new System.Drawing.Size(69, 21);
      this.resType.TabIndex = 5;
      // 
      // tabFunctions
      // 
      this.tabFunctions.Controls.Add(this.tabRsa);
      this.tabFunctions.Controls.Add(this.tab3DES);
      this.tabFunctions.Controls.Add(this.tabTLV);
      this.tabFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabFunctions.Location = new System.Drawing.Point(0, 0);
      this.tabFunctions.Name = "tabFunctions";
      this.tabFunctions.SelectedIndex = 0;
      this.tabFunctions.Size = new System.Drawing.Size(688, 317);
      this.tabFunctions.TabIndex = 6;
      // 
      // tabRsa
      // 
      this.tabRsa.Controls.Add(this.panel1);
      this.tabRsa.Location = new System.Drawing.Point(4, 22);
      this.tabRsa.Name = "tabRsa";
      this.tabRsa.Padding = new System.Windows.Forms.Padding(3);
      this.tabRsa.Size = new System.Drawing.Size(680, 291);
      this.tabRsa.TabIndex = 1;
      this.tabRsa.Text = "RSA";
      this.tabRsa.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(674, 285);
      this.panel1.TabIndex = 0;
      // 
      // tab3DES
      // 
      this.tab3DES.Controls.Add(this.tool3DES1);
      this.tab3DES.Location = new System.Drawing.Point(4, 22);
      this.tab3DES.Name = "tab3DES";
      this.tab3DES.Padding = new System.Windows.Forms.Padding(3);
      this.tab3DES.Size = new System.Drawing.Size(680, 291);
      this.tab3DES.TabIndex = 2;
      this.tab3DES.Text = "3DES";
      this.tab3DES.UseVisualStyleBackColor = true;
      // 
      // tool3DES1
      // 
      this.tool3DES1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tool3DES1.Location = new System.Drawing.Point(3, 3);
      this.tool3DES1.Name = "tool3DES1";
      this.tool3DES1.Size = new System.Drawing.Size(674, 285);
      this.tool3DES1.TabIndex = 0;
      // 
      // tabTLV
      // 
      this.tabTLV.Controls.Add(this.toolTLV1);
      this.tabTLV.Location = new System.Drawing.Point(4, 22);
      this.tabTLV.Name = "tabTLV";
      this.tabTLV.Size = new System.Drawing.Size(680, 291);
      this.tabTLV.TabIndex = 3;
      this.tabTLV.Text = "TLV";
      this.tabTLV.UseVisualStyleBackColor = true;
      // 
      // toolTLV1
      // 
      this.toolTLV1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolTLV1.Location = new System.Drawing.Point(0, 0);
      this.toolTLV1.Name = "toolTLV1";
      this.toolTLV1.Size = new System.Drawing.Size(680, 291);
      this.toolTLV1.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.button1);
      this.splitContainer1.Panel1.Controls.Add(this.txtData);
      this.splitContainer1.Panel1.Controls.Add(this.resType);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.txtRes);
      this.splitContainer1.Panel1.Controls.Add(this.dataType);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabFunctions);
      this.splitContainer1.Size = new System.Drawing.Size(688, 549);
      this.splitContainer1.SplitterDistance = 228;
      this.splitContainer1.TabIndex = 7;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(409, 193);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(267, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Apply that function!";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtData
      // 
      this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtData.Location = new System.Drawing.Point(87, 6);
      this.txtData.Multiline = true;
      this.txtData.Name = "txtData";
      this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtData.Size = new System.Drawing.Size(589, 66);
      this.txtData.TabIndex = 0;
      // 
      // txtRes
      // 
      this.txtRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtRes.Location = new System.Drawing.Point(87, 81);
      this.txtRes.Multiline = true;
      this.txtRes.Name = "txtRes";
      this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRes.Size = new System.Drawing.Size(589, 106);
      this.txtRes.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(688, 549);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "CrypTool";
      this.tabFunctions.ResumeLayout(false);
      this.tabRsa.ResumeLayout(false);
      this.tab3DES.ResumeLayout(false);
      this.tabTLV.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private TextCube txtData;
    private System.Windows.Forms.Label label1;
    private TextCube txtRes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox dataType;
    private System.Windows.Forms.ComboBox resType;
    private System.Windows.Forms.TabControl tabFunctions;
    private System.Windows.Forms.TabPage tabRsa;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TabPage tab3DES;
    private System.Windows.Forms.TabPage tabTLV;
    private ToolRSA panel1;
    private Tool3DES tool3DES1;
    private ToolTLV toolTLV1;
  }
}

