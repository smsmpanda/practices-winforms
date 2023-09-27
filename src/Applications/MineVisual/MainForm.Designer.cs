using MineVisual.Controls.Btn;

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
            uC_TextBox2 = new Controls.UC_TextBox();
            btnDrawArc = new Button();
            firstControl1 = new Controls.FirstControl();
            flashTrackBar1 = new Controls.FlashTrackBar();
            dateTimePicker1 = new DateTimePicker();
            ucBtnExt1 = new UCBtnExt();
            ucBtnFillet2 = new UCBtnFillet();
            ucBtnFillet1 = new UCBtnFillet();
            ucBtnExt2 = new UCBtnExt();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(621, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // ucBtnExt1
            // 
            ucBtnExt1.BackColor = Color.Red;
            ucBtnExt1.BtnBackColor = Color.FromArgb(9, 105, 218);
            ucBtnExt1.BtnFont = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucBtnExt1.BtnForeColor = Color.White;
            ucBtnExt1.BtnText = "搜索";
            ucBtnExt1.ConerRadius = 10;
            ucBtnExt1.EnabledMouseEffect = true;
            ucBtnExt1.FillColor = Color.FromArgb(9, 105, 218);
            ucBtnExt1.IsRadius = true;
            ucBtnExt1.IsShowRect = true;
            ucBtnExt1.IsShowTips = true;
            ucBtnExt1.Location = new Point(467, 25);
            ucBtnExt1.Name = "ucBtnExt1";
            ucBtnExt1.RectColor = Color.FromArgb(9, 105, 218);
            ucBtnExt1.RectWidth = 1;
            ucBtnExt1.Size = new Size(99, 47);
            ucBtnExt1.TabIndex = 8;
            ucBtnExt1.TabStop = false;
            ucBtnExt1.TipForeColor = Color.White;
            ucBtnExt1.TipsColor = Color.FromArgb(255, 128, 0);
            ucBtnExt1.TipsText = "9";
            ucBtnExt1.BtnClick += ucBtnExt1_BtnClick;
            // 
            // ucBtnFillet2
            // 
            ucBtnFillet2.BtnForeColor = Color.White;
            ucBtnFillet2.BtnImage = Properties.Resources.basket;
            ucBtnFillet2.BtnText = "自定义";
            ucBtnFillet2.ConerRadius = 10;
            ucBtnFillet2.FillColor = Color.FromArgb(9, 105, 218);
            ucBtnFillet2.IsRadius = true;
            ucBtnFillet2.IsShowRect = false;
            ucBtnFillet2.Location = new Point(67, 508);
            ucBtnFillet2.Name = "ucBtnFillet2";
            ucBtnFillet2.RectColor = Color.FromArgb(9, 105, 218);
            ucBtnFillet2.RectWidth = 1;
            ucBtnFillet2.Size = new Size(153, 53);
            ucBtnFillet2.TabIndex = 10;
            // 
            // ucBtnFillet1
            // 
            ucBtnFillet1.BtnForeColor = Color.White;
            ucBtnFillet1.BtnImage = (Image)resources.GetObject("ucBtnFillet1.BtnImage");
            ucBtnFillet1.BtnText = "行走的";
            ucBtnFillet1.ConerRadius = 24;
            ucBtnFillet1.FillColor = Color.FromArgb(9, 105, 218);
            ucBtnFillet1.IsRadius = true;
            ucBtnFillet1.IsShowRect = false;
            ucBtnFillet1.Location = new Point(67, 209);
            ucBtnFillet1.Name = "ucBtnFillet1";
            ucBtnFillet1.RectColor = Color.FromArgb(220, 220, 220);
            ucBtnFillet1.RectWidth = 1;
            ucBtnFillet1.Size = new Size(146, 61);
            ucBtnFillet1.TabIndex = 11;
            // 
            // ucBtnExt2
            // 
            ucBtnExt2.BtnBackColor = Color.FromArgb(255, 77, 59);
            ucBtnExt2.BtnFont = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucBtnExt2.BtnForeColor = Color.White;
            ucBtnExt2.BtnText = "退出";
            ucBtnExt2.ConerRadius = 10;
            ucBtnExt2.EnabledMouseEffect = false;
            ucBtnExt2.FillColor = Color.FromArgb(255, 77, 59);
            ucBtnExt2.IsRadius = true;
            ucBtnExt2.IsShowRect = true;
            ucBtnExt2.IsShowTips = true;
            ucBtnExt2.Location = new Point(610, 25);
            ucBtnExt2.Name = "ucBtnExt2";
            ucBtnExt2.RectColor = Color.FromArgb(255, 77, 59);
            ucBtnExt2.RectWidth = 1;
            ucBtnExt2.Size = new Size(111, 52);
            ucBtnExt2.TabIndex = 12;
            ucBtnExt2.TabStop = false;
            ucBtnExt2.TipForeColor = Color.Black;
            ucBtnExt2.TipsColor = Color.FromArgb(255, 128, 0);
            ucBtnExt2.TipsText = "9";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1160, 789);
            Controls.Add(ucBtnExt2);
            Controls.Add(ucBtnFillet1);
            Controls.Add(ucBtnFillet2);
            Controls.Add(ucBtnExt1);
            Controls.Add(dateTimePicker1);
            Controls.Add(flashTrackBar1);
            Controls.Add(firstControl1);
            Controls.Add(btnDrawArc);
            Controls.Add(uC_TextBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Controls.UC_TextBox uC_TextBox2;
        private Button btnDrawArc;
        private Controls.FirstControl firstControl1;
        private Controls.FlashTrackBar flashTrackBar1;
        private DateTimePicker dateTimePicker1;
        private UCBtnExt ucBtnExt1;
        private UCBtnFillet ucBtnFillet2;
        private UCBtnFillet ucBtnFillet1;
        private UCBtnExt ucBtnExt2;
    }
}