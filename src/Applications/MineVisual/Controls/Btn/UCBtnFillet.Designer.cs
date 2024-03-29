﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.Controls.Btn
{
    partial class UCBtnFillet
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
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Cursor = Cursors.Hand;
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl.ForeColor = Color.White;
            lbl.Image = Properties.Resources.basket;
            lbl.ImageAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Padding = new Padding(5, 0, 0, 0);
            lbl.Size = new Size(120, 76);
            lbl.TabIndex = 0;
            lbl.Text = "按钮1   ";
            lbl.TextAlign = ContentAlignment.MiddleRight;
            lbl.MouseDown += lbl_MouseDown;
            // 
            // UCBtnFillet
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            ConerRadius = 5;
            Controls.Add(lbl);
            FillColor = Color.DodgerBlue;
            IsRadius = true;
            IsShowRectBorder = true;
            Name = "UCBtnFillet";
            Size = new Size(120, 76);
            ResumeLayout(false);
        }

        /// <summary>
        /// The label
        /// </summary>
        private Label lbl;
    }
}
