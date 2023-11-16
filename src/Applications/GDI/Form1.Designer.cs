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
            this.firstControl1 = new GDI.UControls.FirstControl();
            this.firstControl2 = new GDI.UControls.FirstControl();
            this.firstControl3 = new GDI.UControls.FirstControl();
            this.firstControl4 = new GDI.UControls.FirstControl();
            this.firstControl5 = new GDI.UControls.FirstControl();
            this.SuspendLayout();
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(214, 65);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(163, 38);
            this.firstControl1.TabIndex = 0;
            this.firstControl1.Text = "firstControl1";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstControl2
            // 
            this.firstControl2.Location = new System.Drawing.Point(107, 79);
            this.firstControl2.Name = "firstControl2";
            this.firstControl2.Size = new System.Drawing.Size(200, 46);
            this.firstControl2.TabIndex = 1;
            this.firstControl2.Text = "firstControl2";
            this.firstControl2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstControl3
            // 
            this.firstControl3.Location = new System.Drawing.Point(235, 263);
            this.firstControl3.Name = "firstControl3";
            this.firstControl3.Size = new System.Drawing.Size(177, 57);
            this.firstControl3.TabIndex = 2;
            this.firstControl3.Text = "firstControl3";
            this.firstControl3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstControl4
            // 
            this.firstControl4.Location = new System.Drawing.Point(235, 234);
            this.firstControl4.Name = "firstControl4";
            this.firstControl4.Size = new System.Drawing.Size(75, 23);
            this.firstControl4.TabIndex = 3;
            this.firstControl4.Text = "firstControl4";
            this.firstControl4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstControl5
            // 
            this.firstControl5.Location = new System.Drawing.Point(290, 172);
            this.firstControl5.Name = "firstControl5";
            this.firstControl5.Size = new System.Drawing.Size(75, 23);
            this.firstControl5.TabIndex = 4;
            this.firstControl5.Text = "firstControl5";
            this.firstControl5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstControl5);
            this.Controls.Add(this.firstControl4);
            this.Controls.Add(this.firstControl3);
            this.Controls.Add(this.firstControl2);
            this.Controls.Add(this.firstControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private UControls.FirstControl firstControl1;
    private UControls.FirstControl firstControl2;
    private UControls.FirstControl firstControl3;
    private UControls.FirstControl firstControl4;
    private UControls.FirstControl firstControl5;
}
