namespace WinformCase.Controls
{
    partial class TextBoxExt
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(21, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(33, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "item";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(81, 4);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(63, 23);
            this.txtText.TabIndex = 2;
            // 
            // TextBoxExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtText);
            this.Name = "TextBoxExt";
            this.Size = new System.Drawing.Size(156, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbName;
        private TextBox txtText;
    }
}
