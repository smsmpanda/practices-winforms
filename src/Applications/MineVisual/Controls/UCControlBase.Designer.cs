using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.Controls
{
    partial class UCControlBase
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
            SuspendLayout();
            // 
            // UCControlBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.DoubleBuffered = true;
            this.Name = "UCControlBase";
            ResumeLayout(false);
        }
    }
}
