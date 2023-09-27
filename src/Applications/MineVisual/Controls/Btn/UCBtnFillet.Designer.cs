using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.Controls.Btn
{
    partial class UCBtnFillet
    {

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pic = new PictureBox();
            lbl = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(pic, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(146, 61);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Right;
            pic.Image = Properties.Resources.basket;
            pic.Location = new Point(3, 18);
            pic.Name = "pic";
            pic.Size = new Size(66, 24);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(75, 20);
            lbl.Name = "lbl";
            lbl.Size = new Size(68, 21);
            lbl.TabIndex = 1;
            lbl.Text = "自定义";
            // 
            // UCBtnFillet
            // 
            Controls.Add(tableLayoutPanel1);
            FillColor = Color.FromArgb(9, 105, 218);
            Name = "UCBtnFillet";
            Size = new Size(146, 61);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl;
        private PictureBox pic;
    }
}
