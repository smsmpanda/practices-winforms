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
        firstControl1 = new UControls.FirstControl();
        SuspendLayout();
        // 
        // firstControl1
        // 
        firstControl1.Location = new Point(112, 97);
        firstControl1.Name = "firstControl1";
        firstControl1.Size = new Size(142, 36);
        firstControl1.TabIndex = 0;
        firstControl1.Text = "firstControl1";
        firstControl1.TextAlignment = ContentAlignment.TopCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(firstControl1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private UControls.FirstControl firstControl1;
}
