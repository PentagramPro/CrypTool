using CryptCommon;
using CryptCommon.Interfaces;
using CrypTool.Tools;

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
            this.tabFunctions = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGeneratePadding = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPadding = new CrypTool.TextCube();
            this.txtData = new CrypTool.TextCube();
            this.txtRes = new CrypTool.TextCube();
            this.cmbPadding = new CrypTool.PaddingCombo();
            this.resType = new CrypTool.DataFormatCombo();
            this.dataType = new CrypTool.DataFormatCombo();
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
            // tabFunctions
            // 
            this.tabFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFunctions.Location = new System.Drawing.Point(0, 0);
            this.tabFunctions.Name = "tabFunctions";
            this.tabFunctions.SelectedIndex = 0;
            this.tabFunctions.Size = new System.Drawing.Size(688, 290);
            this.tabFunctions.TabIndex = 6;
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
            this.splitContainer1.Panel1.Controls.Add(this.cmbPadding);
            this.splitContainer1.Panel1.Controls.Add(this.btnGeneratePadding);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPadding);
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
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnGeneratePadding
            // 
            this.btnGeneratePadding.Location = new System.Drawing.Point(601, 195);
            this.btnGeneratePadding.Name = "btnGeneratePadding";
            this.btnGeneratePadding.Size = new System.Drawing.Size(75, 21);
            this.btnGeneratePadding.TabIndex = 9;
            this.btnGeneratePadding.Text = "Generate";
            this.btnGeneratePadding.UseVisualStyleBackColor = true;
            this.btnGeneratePadding.Click += new System.EventHandler(this.btnGeneratePadding_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Padding:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply that function!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPadding
            // 
            this.txtPadding.ColorEmpty = System.Drawing.Color.White;
            this.txtPadding.ColorError = System.Drawing.Color.LightCoral;
            this.txtPadding.ColorOk = System.Drawing.Color.PaleGreen;
            this.txtPadding.DataFormat = null;
            this.txtPadding.Location = new System.Drawing.Point(64, 195);
            this.txtPadding.Name = "txtPadding";
            this.txtPadding.Size = new System.Drawing.Size(420, 20);
            this.txtPadding.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.ColorEmpty = System.Drawing.Color.Empty;
            this.txtData.ColorError = System.Drawing.Color.LightCoral;
            this.txtData.ColorOk = System.Drawing.Color.LightGreen;
            this.txtData.DataFormat = null;
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
            this.txtRes.ColorEmpty = System.Drawing.Color.Empty;
            this.txtRes.ColorError = System.Drawing.Color.LightCoral;
            this.txtRes.ColorOk = System.Drawing.Color.LightGreen;
            this.txtRes.DataFormat = null;
            this.txtRes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRes.Location = new System.Drawing.Point(87, 81);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRes.Size = new System.Drawing.Size(589, 106);
            this.txtRes.TabIndex = 2;
            // 
            // cmbPadding
            // 
            this.cmbPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPadding.EasySelectedObject = null;
            this.cmbPadding.FormattingEnabled = true;
            this.cmbPadding.Location = new System.Drawing.Point(490, 195);
            this.cmbPadding.Name = "cmbPadding";
            this.cmbPadding.Size = new System.Drawing.Size(105, 21);
            this.cmbPadding.TabIndex = 10;
            // 
            // resType
            // 
            this.resType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resType.EasySelectedObject = null;
            this.resType.FormattingEnabled = true;
            this.resType.Location = new System.Drawing.Point(12, 106);
            this.resType.Name = "resType";
            this.resType.Size = new System.Drawing.Size(69, 21);
            this.resType.TabIndex = 5;
            // 
            // dataType
            // 
            this.dataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataType.EasySelectedObject = null;
            this.dataType.FormattingEnabled = true;
            this.dataType.Location = new System.Drawing.Point(12, 35);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(69, 21);
            this.dataType.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "CrypTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
    private DataFormatCombo dataType;
    private DataFormatCombo resType;
    private System.Windows.Forms.TabControl tabFunctions;

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private TextCube txtPadding;
        private PaddingCombo cmbPadding;
        private System.Windows.Forms.Button btnGeneratePadding;
    }
}

