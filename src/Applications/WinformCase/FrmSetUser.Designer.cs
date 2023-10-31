namespace WinformCase
{
    partial class FrmSetUser
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
            this.gbxHandle = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxBaseInfo = new System.Windows.Forms.GroupBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.cbxBaseType = new System.Windows.Forms.ComboBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.checkIsDel = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHandle.SuspendLayout();
            this.gbxBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHandle
            // 
            this.gbxHandle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxHandle.Controls.Add(this.btnSubmit);
            this.gbxHandle.Controls.Add(this.btnSave);
            this.gbxHandle.Location = new System.Drawing.Point(13, 144);
            this.gbxHandle.Name = "gbxHandle";
            this.gbxHandle.Size = new System.Drawing.Size(509, 61);
            this.gbxHandle.TabIndex = 3;
            this.gbxHandle.TabStop = false;
            this.gbxHandle.Text = "groupBox2";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(428, 22);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "保存";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(728, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbxBaseInfo
            // 
            this.gbxBaseInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxBaseInfo.Controls.Add(this.cbxGender);
            this.gbxBaseInfo.Controls.Add(this.cbxBaseType);
            this.gbxBaseInfo.Controls.Add(this.txtUname);
            this.gbxBaseInfo.Controls.Add(this.checkIsDel);
            this.gbxBaseInfo.Controls.Add(this.label4);
            this.gbxBaseInfo.Controls.Add(this.label2);
            this.gbxBaseInfo.Controls.Add(this.label1);
            this.gbxBaseInfo.Location = new System.Drawing.Point(13, 11);
            this.gbxBaseInfo.Name = "gbxBaseInfo";
            this.gbxBaseInfo.Size = new System.Drawing.Size(509, 127);
            this.gbxBaseInfo.TabIndex = 2;
            this.gbxBaseInfo.TabStop = false;
            this.gbxBaseInfo.Text = "基本信息";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxGender.Location = new System.Drawing.Point(81, 77);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(139, 25);
            this.cbxGender.TabIndex = 7;
            this.cbxGender.Text = "男";
            // 
            // cbxBaseType
            // 
            this.cbxBaseType.FormattingEnabled = true;
            this.cbxBaseType.Location = new System.Drawing.Point(316, 32);
            this.cbxBaseType.Name = "cbxBaseType";
            this.cbxBaseType.Size = new System.Drawing.Size(139, 25);
            this.cbxBaseType.TabIndex = 6;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(81, 32);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(139, 23);
            this.txtUname.TabIndex = 5;
            // 
            // checkIsDel
            // 
            this.checkIsDel.AutoSize = true;
            this.checkIsDel.Location = new System.Drawing.Point(278, 79);
            this.checkIsDel.Name = "checkIsDel";
            this.checkIsDel.Size = new System.Drawing.Size(75, 21);
            this.checkIsDel.TabIndex = 4;
            this.checkIsDel.Text = "是否停用";
            this.checkIsDel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // FrmSetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 217);
            this.Controls.Add(this.gbxHandle);
            this.Controls.Add(this.gbxBaseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSetUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSetUser";
            this.Load += new System.EventHandler(this.FrmSetUser_Load);
            this.gbxHandle.ResumeLayout(false);
            this.gbxBaseInfo.ResumeLayout(false);
            this.gbxBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxHandle;
        private Button btnSubmit;
        private Button btnSave;
        private GroupBox gbxBaseInfo;
        private ComboBox cbxGender;
        private ComboBox cbxBaseType;
        private TextBox txtUname;
        private CheckBox checkIsDel;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}