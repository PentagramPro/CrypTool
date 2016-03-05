namespace CrypTool.Tools
{
  partial class ToolRSA
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtRsaExp = new CrypTool.TextCube();
      this.txtRsaKey = new CrypTool.TextCube();
      this.SuspendLayout();
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(5, 102);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Exponent:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Key:";
      // 
      // txtRsaExp
      // 
      this.txtRsaExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRsaExp.Location = new System.Drawing.Point(5, 118);
      this.txtRsaExp.Multiline = true;
      this.txtRsaExp.Name = "txtRsaExp";
      this.txtRsaExp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRsaExp.Size = new System.Drawing.Size(525, 76);
      this.txtRsaExp.TabIndex = 6;
      // 
      // txtRsaKey
      // 
      this.txtRsaKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRsaKey.Location = new System.Drawing.Point(3, 20);
      this.txtRsaKey.Multiline = true;
      this.txtRsaKey.Name = "txtRsaKey";
      this.txtRsaKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRsaKey.Size = new System.Drawing.Size(527, 68);
      this.txtRsaKey.TabIndex = 5;
      // 
      // ToolRSA
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtRsaExp);
      this.Controls.Add(this.txtRsaKey);
      this.Name = "ToolRSA";
      this.Size = new System.Drawing.Size(533, 233);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private TextCube txtRsaExp;
    private TextCube txtRsaKey;
  }
}
