namespace WinformCase
{
    partial class FrmCoefficientManage
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
            this.dgvCoeffic = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalCoefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculationMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoeffic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoeffic
            // 
            this.dgvCoeffic.AllowUserToAddRows = false;
            this.dgvCoeffic.AllowUserToDeleteRows = false;
            this.dgvCoeffic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoeffic.BackgroundColor = System.Drawing.Color.White;
            this.dgvCoeffic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoeffic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoeffic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AppraisalType,
            this.AppraisalCoefficient,
            this.CalculationMethod,
            this.IsDel});
            this.dgvCoeffic.Location = new System.Drawing.Point(5, 5);
            this.dgvCoeffic.Name = "dgvCoeffic";
            this.dgvCoeffic.ReadOnly = true;
            this.dgvCoeffic.RowTemplate.Height = 25;
            this.dgvCoeffic.Size = new System.Drawing.Size(791, 441);
            this.dgvCoeffic.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // AppraisalType
            // 
            this.AppraisalType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppraisalType.DataPropertyName = "AppraisalType";
            this.AppraisalType.HeaderText = "绩效类型";
            this.AppraisalType.Name = "AppraisalType";
            this.AppraisalType.ReadOnly = true;
            // 
            // AppraisalCoefficient
            // 
            this.AppraisalCoefficient.DataPropertyName = "AppraisalCoefficient";
            this.AppraisalCoefficient.HeaderText = "基数";
            this.AppraisalCoefficient.Name = "AppraisalCoefficient";
            this.AppraisalCoefficient.ReadOnly = true;
            // 
            // CalculationMethod
            // 
            this.CalculationMethod.DataPropertyName = "CalculationMethod";
            this.CalculationMethod.HeaderText = "计算方式";
            this.CalculationMethod.Name = "CalculationMethod";
            this.CalculationMethod.ReadOnly = true;
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否有效";
            this.IsDel.Name = "IsDel";
            this.IsDel.ReadOnly = true;
            // 
            // FrmCoefficientManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCoeffic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCoefficientManage";
            this.Text = "FrmCoefficientManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCoefficientManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoeffic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvCoeffic;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AppraisalType;
        private DataGridViewTextBoxColumn AppraisalCoefficient;
        private DataGridViewTextBoxColumn CalculationMethod;
        private DataGridViewTextBoxColumn IsDel;
    }
}