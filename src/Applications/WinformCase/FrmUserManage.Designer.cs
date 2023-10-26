namespace WinformCase
{
    partial class FrmUserManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkStopWork = new System.Windows.Forms.CheckBox();
            this.cbxBase = new System.Windows.Forms.ComboBox();
            this.lblShenfen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.checkStopWork);
            this.groupBox1.Controls.Add(this.cbxBase);
            this.groupBox1.Controls.Add(this.lblShenfen);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(662, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // checkStopWork
            // 
            this.checkStopWork.AutoSize = true;
            this.checkStopWork.Location = new System.Drawing.Point(413, 35);
            this.checkStopWork.Name = "checkStopWork";
            this.checkStopWork.Size = new System.Drawing.Size(63, 21);
            this.checkStopWork.TabIndex = 4;
            this.checkStopWork.Text = "已停职";
            this.checkStopWork.UseVisualStyleBackColor = true;
            // 
            // cbxBase
            // 
            this.cbxBase.FormattingEnabled = true;
            this.cbxBase.Location = new System.Drawing.Point(248, 33);
            this.cbxBase.Name = "cbxBase";
            this.cbxBase.Size = new System.Drawing.Size(121, 25);
            this.cbxBase.TabIndex = 3;
            // 
            // lblShenfen
            // 
            this.lblShenfen.AutoSize = true;
            this.lblShenfen.Location = new System.Drawing.Point(210, 38);
            this.lblShenfen.Name = "lblShenfen";
            this.lblShenfen.Size = new System.Drawing.Size(32, 17);
            this.lblShenfen.TabIndex = 2;
            this.lblShenfen.Text = "身份";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(27, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManage";
            this.Text = "FrmUserMange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblUserName;
        private Button btnSearch;
        private CheckBox checkStopWork;
        private ComboBox cbxBase;
        private Label lblShenfen;
        private TextBox textBox1;
    }
}