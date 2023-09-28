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
            this.uC_TextBox2 = new MineVisual.Controls.UC_TextBox();
            this.btnDrawArc = new System.Windows.Forms.Button();
            this.firstControl1 = new MineVisual.Controls.FirstControl();
            this.flashTrackBar1 = new MineVisual.Controls.FlashTrackBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ucBtnExt1 = new MineVisual.Controls.Btn.UCBtnExt();
            this.ucBtnExt2 = new MineVisual.Controls.Btn.UCBtnExt();
            this.ucBtnFillet1 = new MineVisual.Controls.Btn.UCBtnFillet();
            this.ucBtnImage1 = new MineVisual.Controls.Btn.UCBtnImage();
            this.SuspendLayout();
            // 
            // uC_TextBox2
            // 
            this.uC_TextBox2.BackColor = System.Drawing.Color.White;
            this.uC_TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_TextBox2.IsRound = false;
            this.uC_TextBox2.Location = new System.Drawing.Point(621, 100);
            this.uC_TextBox2.Name = "uC_TextBox2";
            this.uC_TextBox2.Size = new System.Drawing.Size(255, 46);
            this.uC_TextBox2.TabIndex = 2;
            // 
            // btnDrawArc
            // 
            this.btnDrawArc.Location = new System.Drawing.Point(621, 165);
            this.btnDrawArc.Name = "btnDrawArc";
            this.btnDrawArc.Size = new System.Drawing.Size(75, 23);
            this.btnDrawArc.TabIndex = 3;
            this.btnDrawArc.Text = "画弧线";
            this.btnDrawArc.UseVisualStyleBackColor = true;
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(719, 165);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(147, 27);
            this.firstControl1.TabIndex = 4;
            this.firstControl1.Text = "firstControl1";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashTrackBar1
            // 
            this.flashTrackBar1.BackColor = System.Drawing.Color.Black;
            this.flashTrackBar1.ForeColor = System.Drawing.Color.White;
            this.flashTrackBar1.Location = new System.Drawing.Point(621, 217);
            this.flashTrackBar1.Max = 1000;
            this.flashTrackBar1.Name = "flashTrackBar1";
            this.flashTrackBar1.ShowPercentage = true;
            this.flashTrackBar1.Size = new System.Drawing.Size(100, 23);
            this.flashTrackBar1.TabIndex = 5;
            this.flashTrackBar1.Text = "flashTrackBar1";
            this.flashTrackBar1.Value = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Red;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "搜索";
            this.ucBtnExt1.ConerRadius = 10;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRectBorder = true;
            this.ucBtnExt1.IsShowTips = true;
            this.ucBtnExt1.Location = new System.Drawing.Point(467, 25);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.ucBtnExt1.RectBorderWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(99, 47);
            this.ucBtnExt1.TabIndex = 8;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucBtnExt1.TipsText = "9";
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "退出";
            this.ucBtnExt2.ConerRadius = 10;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRectBorder = true;
            this.ucBtnExt2.IsShowTips = true;
            this.ucBtnExt2.Location = new System.Drawing.Point(610, 25);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.RectBorderWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(111, 52);
            this.ucBtnExt2.TabIndex = 12;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucBtnExt2.TipsText = "9";
            // 
            // ucBtnFillet1
            // 
            this.ucBtnFillet1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnFillet1.BtnForeColor = System.Drawing.Color.Transparent;
            this.ucBtnFillet1.BtnText = "按钮1   ";
            this.ucBtnFillet1.ConerRadius = 9;
            this.ucBtnFillet1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.ucBtnFillet1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnFillet1.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnFillet1.Image")));
            this.ucBtnFillet1.IsRadius = true;
            this.ucBtnFillet1.IsShowRectBorder = true;
            this.ucBtnFillet1.Location = new System.Drawing.Point(467, 100);
            this.ucBtnFillet1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucBtnFillet1.Name = "ucBtnFillet1";
            this.ucBtnFillet1.RectBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucBtnFillet1.RectBorderWidth = 1;
            this.ucBtnFillet1.Size = new System.Drawing.Size(118, 40);
            this.ucBtnFillet1.TabIndex = 13;
            // 
            // ucBtnImage1
            // 
            this.ucBtnImage1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImage1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImage1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucBtnImage1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnImage1.BtnText = "";
            this.ucBtnImage1.ConerRadius = 5;
            this.ucBtnImage1.EnabledMouseEffect = false;
            this.ucBtnImage1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnImage1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImage1.Image = global::MineVisual.Properties.Resources.basket;
            this.ucBtnImage1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImage1.IsRadius = true;
            this.ucBtnImage1.IsShowRectBorder = true;
            this.ucBtnImage1.IsShowTips = true;
            this.ucBtnImage1.Location = new System.Drawing.Point(629, 339);
            this.ucBtnImage1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImage1.Name = "ucBtnImage1";
            this.ucBtnImage1.RectBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnImage1.RectBorderWidth = 1;
            this.ucBtnImage1.Size = new System.Drawing.Size(92, 49);
            this.ucBtnImage1.TabIndex = 14;
            this.ucBtnImage1.TabStop = false;
            this.ucBtnImage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImage1.TipForeColor = System.Drawing.Color.Black;
            this.ucBtnImage1.TipsColor = System.Drawing.Color.White;
            this.ucBtnImage1.TipsText = "9+";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 733);
            this.Controls.Add(this.ucBtnImage1);
            this.Controls.Add(this.ucBtnFillet1);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flashTrackBar1);
            this.Controls.Add(this.firstControl1);
            this.Controls.Add(this.btnDrawArc);
            this.Controls.Add(this.uC_TextBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.UC_TextBox uC_TextBox2;
        private Button btnDrawArc;
        private Controls.FirstControl firstControl1;
        private Controls.FlashTrackBar flashTrackBar1;
        private DateTimePicker dateTimePicker1;
        private UCBtnExt ucBtnExt1;
        private UCBtnExt ucBtnExt2;
        private UCBtnFillet ucBtnFillet1;
        private UCBtnImage ucBtnImage1;
    }
}