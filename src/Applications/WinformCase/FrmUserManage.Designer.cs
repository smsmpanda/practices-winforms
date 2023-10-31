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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkStopWork = new System.Windows.Forms.CheckBox();
            this.cbxBaseType = new System.Windows.Forms.ComboBox();
            this.lblShenfen = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsUserManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.cmsUserManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.checkStopWork);
            this.groupBox1.Controls.Add(this.cbxBaseType);
            this.groupBox1.Controls.Add(this.lblShenfen);
            this.groupBox1.Controls.Add(this.txtName);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // cbxBaseType
            // 
            this.cbxBaseType.FormattingEnabled = true;
            this.cbxBaseType.Location = new System.Drawing.Point(248, 33);
            this.cbxBaseType.Name = "cbxBaseType";
            this.cbxBaseType.Size = new System.Drawing.Size(121, 25);
            this.cbxBaseType.TabIndex = 3;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
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
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Sex,
            this.BaseType,
            this.AppraisalBase,
            this.IsDel});
            this.dgvUser.ContextMenuStrip = this.cmsUserManage;
            this.dgvUser.Location = new System.Drawing.Point(12, 101);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(776, 337);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_CellMouseDown);
            this.dgvUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUser_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // BaseType
            // 
            this.BaseType.DataPropertyName = "BaseType";
            this.BaseType.HeaderText = "基数类型";
            this.BaseType.Name = "BaseType";
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "基数";
            this.AppraisalBase.Name = "AppraisalBase";
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否停职";
            this.IsDel.Name = "IsDel";
            // 
            // cmsUserManage
            // 
            this.cmsUserManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsUserAdd,
            this.cmsUserEdit,
            this.cmsUserEnable,
            this.cmsUserDisable});
            this.cmsUserManage.Name = "cmsUserManage";
            this.cmsUserManage.Size = new System.Drawing.Size(101, 92);
            // 
            // cmsUserAdd
            // 
            this.cmsUserAdd.Name = "cmsUserAdd";
            this.cmsUserAdd.Size = new System.Drawing.Size(100, 22);
            this.cmsUserAdd.Text = "新建";
            // 
            // cmsUserEdit
            // 
            this.cmsUserEdit.Name = "cmsUserEdit";
            this.cmsUserEdit.Size = new System.Drawing.Size(100, 22);
            this.cmsUserEdit.Text = "编辑";
            // 
            // cmsUserEnable
            // 
            this.cmsUserEnable.Name = "cmsUserEnable";
            this.cmsUserEnable.Size = new System.Drawing.Size(100, 22);
            this.cmsUserEnable.Text = "启用";
            // 
            // cmsUserDisable
            // 
            this.cmsUserDisable.Name = "cmsUserDisable";
            this.cmsUserDisable.Size = new System.Drawing.Size(100, 22);
            this.cmsUserDisable.Text = "停用";
            // 
            // FrmUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManage";
            this.Text = "FrmUserMange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.cmsUserManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvUser;
        private Label lblUserName;
        private Button btnSearch;
        private CheckBox checkStopWork;
        private ComboBox cbxBaseType;
        private Label lblShenfen;
        private TextBox txtName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn BaseType;
        private DataGridViewTextBoxColumn AppraisalBase;
        private DataGridViewTextBoxColumn IsDel;
        private ContextMenuStrip cmsUserManage;
        private ToolStripMenuItem cmsUserAdd;
        private ToolStripMenuItem cmsUserEdit;
        private ToolStripMenuItem cmsUserEnable;
        private ToolStripMenuItem cmsUserDisable;
    }
}