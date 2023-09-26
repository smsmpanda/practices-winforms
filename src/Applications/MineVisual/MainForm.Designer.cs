namespace MineVisual
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            uC_TextBox2 = new UserControls.UC_TextBox();
            uC_TextBoxPadding1 = new UserControls.UC_TextBoxPadding();
            btnDrawArc = new Button();
            firstControl1 = new UserControls.FirstControl();
            flashTrackBar1 = new UserControls.FlashTrackBar();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            baseButton1 = new UserControls.BaseButton();
            SuspendLayout();
            // 
            // uC_TextBox2
            // 
            uC_TextBox2.BackColor = Color.White;
            uC_TextBox2.BorderStyle = BorderStyle.FixedSingle;
            uC_TextBox2.IsRound = false;
            uC_TextBox2.Location = new Point(621, 95);
            uC_TextBox2.Name = "uC_TextBox2";
            uC_TextBox2.Size = new Size(255, 46);
            uC_TextBox2.TabIndex = 2;
            // 
            // uC_TextBoxPadding1
            // 
            uC_TextBoxPadding1.BorderStyle = BorderStyle.FixedSingle;
            uC_TextBoxPadding1.Location = new Point(621, 25);
            uC_TextBoxPadding1.Name = "uC_TextBoxPadding1";
            uC_TextBoxPadding1.Padding = new Padding(15);
            uC_TextBoxPadding1.Size = new Size(317, 47);
            uC_TextBoxPadding1.TabIndex = 1;
            // 
            // btnDrawArc
            // 
            btnDrawArc.Location = new Point(621, 165);
            btnDrawArc.Name = "btnDrawArc";
            btnDrawArc.Size = new Size(75, 23);
            btnDrawArc.TabIndex = 3;
            btnDrawArc.Text = "画弧线";
            btnDrawArc.UseVisualStyleBackColor = true;
            // 
            // firstControl1
            // 
            firstControl1.Location = new Point(719, 165);
            firstControl1.Name = "firstControl1";
            firstControl1.Size = new Size(147, 27);
            firstControl1.TabIndex = 4;
            firstControl1.Text = "firstControl1";
            firstControl1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flashTrackBar1
            // 
            flashTrackBar1.BackColor = Color.Black;
            flashTrackBar1.ForeColor = Color.White;
            flashTrackBar1.Location = new Point(621, 217);
            flashTrackBar1.Max = 1000;
            flashTrackBar1.Name = "flashTrackBar1";
            flashTrackBar1.ShowPercentage = true;
            flashTrackBar1.Size = new Size(100, 23);
            flashTrackBar1.TabIndex = 5;
            flashTrackBar1.Text = "flashTrackBar1";
            flashTrackBar1.Value = 10;
            // 
            // button1
            // 
            button1.Location = new Point(154, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // baseButton1
            // 
            baseButton1.Cursor = Cursors.Hand;
            baseButton1.CustomBackColor = Color.DodgerBlue;
            baseButton1.CustomBorderColor = Color.Empty;
            baseButton1.CustomBorderWidth = 0;
            baseButton1.CustomContent = "测试按钮";
            baseButton1.CustomContentAlignment = ContentAlignment.MiddleCenter;
            baseButton1.CustomMouseEnterBackColor = Color.FromArgb(2, 23, 12);
            baseButton1.CustomRadius = 7;
            baseButton1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            baseButton1.ForeColor = Color.White;
            baseButton1.Location = new Point(128, 346);
            baseButton1.Name = "baseButton1";
            baseButton1.Size = new Size(101, 38);
            baseButton1.TabIndex = 8;
            baseButton1.ButtonClick += baseButton1_ButtonClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 763);
            Controls.Add(baseButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(flashTrackBar1);
            Controls.Add(firstControl1);
            Controls.Add(btnDrawArc);
            Controls.Add(uC_TextBox2);
            Controls.Add(uC_TextBoxPadding1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private UserControls.UC_TextBox uC_TextBox2;
        private UserControls.UC_TextBoxPadding uC_TextBoxPadding1;
        private Button btnDrawArc;
        private UserControls.FirstControl firstControl1;
        private UserControls.FlashTrackBar flashTrackBar1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private UserControls.BaseButton baseButton1;
    }
}