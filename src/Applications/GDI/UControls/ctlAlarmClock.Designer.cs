namespace GDI.UControls
{
    partial class ctlAlarmClock
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
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(3, 5);
            this.lblDisplay.Size = new System.Drawing.Size(77, 25);
            this.lblDisplay.Text = "9:21:05";
            // 
            // lblAlarm
            // 
            this.lblAlarm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(101, 14);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(43, 17);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "label1";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarm.Visible = false;
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAlarmOff.Location = new System.Drawing.Point(80, 44);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(75, 23);
            this.btnAlarmOff.TabIndex = 2;
            this.btnAlarmOff.Text = "禁用警报";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
            // 
            // ctlAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.lblAlarm);
            this.Name = "ctlAlarmClock";
            this.Size = new System.Drawing.Size(169, 73);
            this.Controls.SetChildIndex(this.lblDisplay, 0);
            this.Controls.SetChildIndex(this.lblAlarm, 0);
            this.Controls.SetChildIndex(this.btnAlarmOff, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label lblAlarm;
        private Button btnAlarmOff;
    }
}
