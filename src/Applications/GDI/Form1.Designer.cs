namespace GDI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.userControlBase1 = new GDI.UserControlBase();
            this.SuspendLayout();
            // 
            // userControlBase1
            // 
            this.userControlBase1.BackColor = System.Drawing.Color.Transparent;
            this.userControlBase1.ExtBorderColor = System.Drawing.Color.IndianRed;
            this.userControlBase1.ExtBorderWidth = 0;
            this.userControlBase1.ExtFillColor = System.Drawing.Color.Black;
            this.userControlBase1.ExtRadius = 5;
            this.userControlBase1.Location = new System.Drawing.Point(277, 118);
            this.userControlBase1.Name = "userControlBase1";
            this.userControlBase1.Size = new System.Drawing.Size(120, 50);
            this.userControlBase1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlBase1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private UserControlBase userControlBase1;
}
