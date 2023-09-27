namespace MineVisual.Controls
{
    partial class UC_TextBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            icon = new PictureBox();
            txt = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(icon, 0, 0);
            tableLayoutPanel1.Controls.Add(txt, 1, 0);
            tableLayoutPanel1.Location = new Point(9, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(235, 32);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // icon
            // 
            icon.Dock = DockStyle.Fill;
            icon.Image = Properties.Resources.login_user;
            icon.Location = new Point(3, 3);
            icon.Name = "icon";
            icon.Size = new Size(25, 26);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 0;
            icon.TabStop = false;
            // 
            // txt
            // 
            txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt.BorderStyle = BorderStyle.None;
            txt.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt.Location = new Point(34, 5);
            txt.Name = "txt";
            txt.Size = new Size(198, 21);
            txt.TabIndex = 1;
            // 
            // UC_TextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_TextBox";
            Size = new Size(255, 46);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox icon;
        private TextBox txt;
    }
}
