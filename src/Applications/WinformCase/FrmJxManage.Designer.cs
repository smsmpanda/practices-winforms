namespace WinformCase
{
    partial class FrmJxManage
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
            this.dgvJx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJx
            // 
            this.dgvJx.AllowUserToAddRows = false;
            this.dgvJx.AllowUserToDeleteRows = false;
            this.dgvJx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJx.Location = new System.Drawing.Point(0, 0);
            this.dgvJx.Name = "dgvJx";
            this.dgvJx.ReadOnly = true;
            this.dgvJx.RowTemplate.Height = 25;
            this.dgvJx.Size = new System.Drawing.Size(800, 450);
            this.dgvJx.TabIndex = 0;
            // 
            // FrmJxManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvJx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJxManage";
            this.Text = "FrmJxManage";
            this.Load += new System.EventHandler(this.FrmJxManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvJx;
    }
}