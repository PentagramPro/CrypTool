namespace CrypTool.Tools
{
  partial class Tool3DES
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
      this.cmb3DESMode = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txt3DESKey = new CrypTool.TextCube();
      this.cmb3DESChaining = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmb3DESMode
      // 
      this.cmb3DESMode.FormattingEnabled = true;
      this.cmb3DESMode.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
      this.cmb3DESMode.Location = new System.Drawing.Point(6, 61);
      this.cmb3DESMode.Name = "cmb3DESMode";
      this.cmb3DESMode.Size = new System.Drawing.Size(121, 21);
      this.cmb3DESMode.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 37);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Chaining mode:";
      // 
      // txt3DESKey
      // 
      this.txt3DESKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt3DESKey.Location = new System.Drawing.Point(37, 3);
      this.txt3DESKey.Name = "txt3DESKey";
      this.txt3DESKey.Size = new System.Drawing.Size(426, 20);
      this.txt3DESKey.TabIndex = 7;
      // 
      // cmb3DESChaining
      // 
      this.cmb3DESChaining.FormattingEnabled = true;
      this.cmb3DESChaining.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
      this.cmb3DESChaining.Location = new System.Drawing.Point(89, 34);
      this.cmb3DESChaining.Name = "cmb3DESChaining";
      this.cmb3DESChaining.Size = new System.Drawing.Size(186, 21);
      this.cmb3DESChaining.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Key:";
      // 
      // Tool3DES
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cmb3DESMode);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txt3DESKey);
      this.Controls.Add(this.cmb3DESChaining);
      this.Controls.Add(this.label5);
      this.Name = "Tool3DES";
      this.Size = new System.Drawing.Size(484, 244);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmb3DESMode;
    private System.Windows.Forms.Label label6;
    private TextCube txt3DESKey;
    private System.Windows.Forms.ComboBox cmb3DESChaining;
    private System.Windows.Forms.Label label5;
  }
}
