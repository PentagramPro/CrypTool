namespace CryptHashes
{
  partial class HashCalc
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
      this.radioMD5 = new System.Windows.Forms.RadioButton();
      this.radioSHA1 = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // radioMD5
      // 
      this.radioMD5.AutoSize = true;
      this.radioMD5.Location = new System.Drawing.Point(15, 15);
      this.radioMD5.Name = "radioMD5";
      this.radioMD5.Size = new System.Drawing.Size(48, 17);
      this.radioMD5.TabIndex = 0;
      this.radioMD5.TabStop = true;
      this.radioMD5.Text = "MD5";
      this.radioMD5.UseVisualStyleBackColor = true;
      // 
      // radioSHA1
      // 
      this.radioSHA1.AutoSize = true;
      this.radioSHA1.Location = new System.Drawing.Point(15, 58);
      this.radioSHA1.Name = "radioSHA1";
      this.radioSHA1.Size = new System.Drawing.Size(56, 17);
      this.radioSHA1.TabIndex = 1;
      this.radioSHA1.TabStop = true;
      this.radioSHA1.Text = "SHA-1";
      this.radioSHA1.UseVisualStyleBackColor = true;
      // 
      // HashCalc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.radioSHA1);
      this.Controls.Add(this.radioMD5);
      this.Name = "HashCalc";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton radioMD5;
    private System.Windows.Forms.RadioButton radioSHA1;
  }
}
