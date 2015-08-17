namespace CrypTool.Tools
{
  partial class ToolTLV
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
      this.chkViVO = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // chkViVO
      // 
      this.chkViVO.AutoSize = true;
      this.chkViVO.Location = new System.Drawing.Point(13, 16);
      this.chkViVO.Name = "chkViVO";
      this.chkViVO.Size = new System.Drawing.Size(91, 17);
      this.chkViVO.TabIndex = 1;
      this.chkViVO.Text = "ViVO Settings";
      this.chkViVO.UseVisualStyleBackColor = true;
      // 
      // ToolTLV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.chkViVO);
      this.Name = "ToolTLV";
      this.Size = new System.Drawing.Size(619, 276);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox chkViVO;
  }
}
