using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.Controls.Btn
{
    partial class UCBtnExt
    {

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbl = new Label();
            lblTips = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.BackColor = Color.Transparent;
            lbl.Cursor = Cursors.Hand;
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.ImageAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(147, 64);
            lbl.TabIndex = 0;
            lbl.Text = "自定义按钮";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.MouseDown += lbl_MouseDown;
            // 
            // lblTips
            // 
            lblTips.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTips.BackColor = Color.Transparent;
            lblTips.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTips.ForeColor = Color.White;
            lblTips.Location = new Point(120, 0);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(24, 24);
            lblTips.TabIndex = 1;
            lblTips.TextAlign = ContentAlignment.MiddleCenter;
            lblTips.Visible = false;
            lblTips.Paint += lblTips_Paint;
            // 
            // UCBtnExt
            // 
            ConerRadius = 5;
            Controls.Add(lblTips);
            Controls.Add(lbl);
            FillColor = Color.FromArgb(255, 77, 59);
            IsRadius = true;
            IsShowRectBorder = true;
            Name = "UCBtnExt";
            RectBorderColor = Color.FromArgb(255, 77, 59);
            Size = new Size(147, 64);
            ResumeLayout(false);
        }

        public Label lbl;
        public Label lblTips;
    }
}
