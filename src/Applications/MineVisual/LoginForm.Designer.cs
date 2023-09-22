namespace MineVisual;

partial class LoginForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        label1 = new Label();
        label2 = new Label();
        txtAccount = new TextBox();
        txtPwd = new TextBox();
        button1 = new Button();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(18, 32);
        label1.Name = "label1";
        label1.Size = new Size(39, 20);
        label1.TabIndex = 0;
        label1.Text = "账号";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(18, 75);
        label2.Name = "label2";
        label2.Size = new Size(39, 20);
        label2.TabIndex = 1;
        label2.Text = "密码";
        // 
        // txtAccount
        // 
        txtAccount.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtAccount.Location = new Point(63, 30);
        txtAccount.Name = "txtAccount";
        txtAccount.Size = new Size(198, 24);
        txtAccount.TabIndex = 2;
        // 
        // txtPwd
        // 
        txtPwd.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtPwd.Location = new Point(63, 73);
        txtPwd.Margin = new Padding(5);
        txtPwd.Name = "txtPwd";
        txtPwd.PasswordChar = '*';
        txtPwd.Size = new Size(198, 24);
        txtPwd.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(63, 118);
        button1.Name = "button1";
        button1.Size = new Size(198, 38);
        button1.TabIndex = 5;
        button1.Text = "登录";
        button1.UseVisualStyleBackColor = true;
        button1.Click += OnLogin_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(93, 176);
        label3.Name = "label3";
        label3.Size = new Size(125, 16);
        label3.TabIndex = 6;
        label3.Text = "版权所有©smsmpanda";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        BackColor = Color.White;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(290, 201);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(txtPwd);
        Controls.Add(txtAccount);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtAccount;
    private TextBox txtPwd;
    private Button button1;
    private Label label3;
}
