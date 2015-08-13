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
      this.txtData = new CrypTool.TextCube();
      this.label1 = new System.Windows.Forms.Label();
      this.txtRes = new CrypTool.TextCube();
      this.label2 = new System.Windows.Forms.Label();
      this.dataType = new System.Windows.Forms.ComboBox();
      this.resType = new System.Windows.Forms.ComboBox();
      this.tabFunctions = new System.Windows.Forms.TabControl();
      this.tabRsa = new System.Windows.Forms.TabPage();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtRsaExp = new CrypTool.TextCube();
      this.txtRsaKey = new CrypTool.TextCube();
      this.tabSha1 = new System.Windows.Forms.TabPage();
      this.tab3DES = new System.Windows.Forms.TabPage();
      this.cmb3DESMode = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txt3DESKey = new CrypTool.TextCube();
      this.cmb3DESChaining = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.button1 = new System.Windows.Forms.Button();
      this.tabTLV = new System.Windows.Forms.TabPage();
      this.chkViVO = new System.Windows.Forms.CheckBox();
      this.tabFunctions.SuspendLayout();
      this.tabRsa.SuspendLayout();
      this.tab3DES.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabTLV.SuspendLayout();
      this.SuspendLayout();
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Data";
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
      this.tabFunctions.Controls.Add(this.tabSha1);
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
      this.tabRsa.Controls.Add(this.label4);
      this.tabRsa.Controls.Add(this.label3);
      this.tabRsa.Controls.Add(this.txtRsaExp);
      this.tabRsa.Controls.Add(this.txtRsaKey);
      this.tabRsa.Location = new System.Drawing.Point(4, 22);
      this.tabRsa.Name = "tabRsa";
      this.tabRsa.Padding = new System.Windows.Forms.Padding(3);
      this.tabRsa.Size = new System.Drawing.Size(568, 250);
      this.tabRsa.TabIndex = 0;
      this.tabRsa.Text = "RSA";
      this.tabRsa.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 114);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Exponent:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Key:";
      // 
      // txtRsaExp
      // 
      this.txtRsaExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRsaExp.Location = new System.Drawing.Point(10, 130);
      this.txtRsaExp.Multiline = true;
      this.txtRsaExp.Name = "txtRsaExp";
      this.txtRsaExp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRsaExp.Size = new System.Drawing.Size(550, 66);
      this.txtRsaExp.TabIndex = 2;
      // 
      // txtRsaKey
      // 
      this.txtRsaKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRsaKey.Location = new System.Drawing.Point(8, 32);
      this.txtRsaKey.Multiline = true;
      this.txtRsaKey.Name = "txtRsaKey";
      this.txtRsaKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRsaKey.Size = new System.Drawing.Size(552, 66);
      this.txtRsaKey.TabIndex = 1;
      // 
      // tabSha1
      // 
      this.tabSha1.Location = new System.Drawing.Point(4, 22);
      this.tabSha1.Name = "tabSha1";
      this.tabSha1.Padding = new System.Windows.Forms.Padding(3);
      this.tabSha1.Size = new System.Drawing.Size(568, 250);
      this.tabSha1.TabIndex = 1;
      this.tabSha1.Text = "SHA-1";
      this.tabSha1.UseVisualStyleBackColor = true;
      // 
      // tab3DES
      // 
      this.tab3DES.Controls.Add(this.cmb3DESMode);
      this.tab3DES.Controls.Add(this.label6);
      this.tab3DES.Controls.Add(this.txt3DESKey);
      this.tab3DES.Controls.Add(this.cmb3DESChaining);
      this.tab3DES.Controls.Add(this.label5);
      this.tab3DES.Location = new System.Drawing.Point(4, 22);
      this.tab3DES.Name = "tab3DES";
      this.tab3DES.Padding = new System.Windows.Forms.Padding(3);
      this.tab3DES.Size = new System.Drawing.Size(568, 250);
      this.tab3DES.TabIndex = 2;
      this.tab3DES.Text = "3DES";
      this.tab3DES.UseVisualStyleBackColor = true;
      // 
      // cmb3DESMode
      // 
      this.cmb3DESMode.FormattingEnabled = true;
      this.cmb3DESMode.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
      this.cmb3DESMode.Location = new System.Drawing.Point(11, 68);
      this.cmb3DESMode.Name = "cmb3DESMode";
      this.cmb3DESMode.Size = new System.Drawing.Size(121, 21);
      this.cmb3DESMode.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(8, 44);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Chaining mode:";
      // 
      // txt3DESKey
      // 
      this.txt3DESKey.Location = new System.Drawing.Point(42, 10);
      this.txt3DESKey.Name = "txt3DESKey";
      this.txt3DESKey.Size = new System.Drawing.Size(485, 20);
      this.txt3DESKey.TabIndex = 2;
      // 
      // cmb3DESChaining
      // 
      this.cmb3DESChaining.FormattingEnabled = true;
      this.cmb3DESChaining.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
      this.cmb3DESChaining.Location = new System.Drawing.Point(94, 41);
      this.cmb3DESChaining.Name = "cmb3DESChaining";
      this.cmb3DESChaining.Size = new System.Drawing.Size(186, 21);
      this.cmb3DESChaining.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Key:";
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
      // tabTLV
      // 
      this.tabTLV.Controls.Add(this.chkViVO);
      this.tabTLV.Location = new System.Drawing.Point(4, 22);
      this.tabTLV.Name = "tabTLV";
      this.tabTLV.Size = new System.Drawing.Size(680, 291);
      this.tabTLV.TabIndex = 3;
      this.tabTLV.Text = "TLV";
      this.tabTLV.UseVisualStyleBackColor = true;
      // 
      // chkViVO
      // 
      this.chkViVO.AutoSize = true;
      this.chkViVO.Location = new System.Drawing.Point(11, 16);
      this.chkViVO.Name = "chkViVO";
      this.chkViVO.Size = new System.Drawing.Size(91, 17);
      this.chkViVO.TabIndex = 0;
      this.chkViVO.Text = "ViVO Settings";
      this.chkViVO.UseVisualStyleBackColor = true;
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
      this.tabRsa.PerformLayout();
      this.tab3DES.ResumeLayout(false);
      this.tab3DES.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabTLV.ResumeLayout(false);
      this.tabTLV.PerformLayout();
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
    private System.Windows.Forms.TabPage tabSha1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private TextCube txtRsaExp;
    private TextCube txtRsaKey;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TabPage tab3DES;
    private System.Windows.Forms.Label label6;
    private TextCube txt3DESKey;
    private System.Windows.Forms.ComboBox cmb3DESChaining;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmb3DESMode;
    private System.Windows.Forms.TabPage tabTLV;
    private System.Windows.Forms.CheckBox chkViVO;
  }
}

