﻿using MineVisual.Extensions;
using System.ComponentModel;

namespace MineVisual.Controls.Btn
{
    [DefaultEvent(nameof(BtnClick))]
    public partial class UCBtnExt : UCControlBase
    {
        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event EventHandler? BtnClick;


        private bool enabledMouseEffect = false;
        [Description("是否启用鼠标效果"), Category("自定义")]
        public bool EnabledMouseEffect
        {
            get { return enabledMouseEffect; }
            set { enabledMouseEffect = value; }
        }


        /// <summary>
        /// 是否显示角标
        /// </summary>
        /// <value><c>true</c> if this instance is show tips; otherwise, <c>false</c>.</value>
        [Description("是否显示角标"), Category("自定义")]
        public bool IsShowTips
        {
            get
            {
                return lblTips.Visible;
            }
            set
            {
                lblTips.Visible = value;
            }
        }

        /// <summary>
        /// 角标文字
        /// </summary>
        /// <value>The tips text.</value>
        [Description("角标文字"), Category("自定义")]
        public string TipsText
        {
            get
            {
                return lblTips.Text;
            }
            set
            {
                lblTips.Text = value;
            }
        }

        /// <summary>
        /// The button fore color
        /// </summary>
        private Color _tipForeColor = Color.Black;
        /// <summary>
        /// 按钮字体颜色
        /// </summary>
        /// <value>The color of the BTN fore.</value>
        [Description("角标文字字体颜色"), Category("自定义")]
        public virtual Color TipForeColor
        {
            get { return _tipForeColor; }
            set
            {
                _tipForeColor = value;
                lblTips.ForeColor = value;
            }
        }


        /// <summary>
        /// The button back color
        /// </summary>
        private Color _btnBackColor = Color.Transparent;
        /// <summary>
        /// 按钮背景色
        /// </summary>
        /// <value>The color of the BTN back.</value>
        [Description("按钮背景色"), Category("自定义")]
        public Color BtnBackColor
        {
            get { return _btnBackColor; }
            set
            {
                _btnBackColor = value;
                this.lbl.BackColor = value;
            }
        }

        /// <summary>
        /// The button fore color
        /// </summary>
        private Color _btnForeColor = Color.White;
        /// <summary>
        /// 按钮字体颜色
        /// </summary>
        /// <value>The color of the BTN fore.</value>
        [Description("按钮字体颜色"), Category("自定义")]
        public virtual Color BtnForeColor
        {
            get { return _btnForeColor; }
            set
            {
                _btnForeColor = value;
                lbl.ForeColor = value;
            }
        }

        /// <summary>
        /// The button font
        /// </summary>
        private Font _btnFont = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)(134));
        /// <summary>
        /// 按钮字体
        /// </summary>
        /// <value>The BTN font.</value>
        [Description("按钮字体"), Category("自定义")]
        public Font BtnFont
        {
            get { return _btnFont; }
            set
            {
                _btnFont = value;
                lbl.Font = value;
            }
        }

        /// <summary>
        /// The button text
        /// </summary>
        private string _btnText;
        /// <summary>
        /// 按钮文字
        /// </summary>
        /// <value>The BTN text.</value>
        [Description("按钮文字"), Category("自定义")]
        public virtual string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                lbl.Text = value;
            }
        }

        /// <summary>
        /// The m tips color
        /// </summary>
        private Color m_tipsColor = Color.FromArgb(232, 30, 99);



        /// <summary>
        /// 角标颜色
        /// </summary>
        /// <value>The color of the tips.</value>
        [Description("角标颜色"), Category("自定义")]
        public Color TipsColor
        {
            get { return m_tipsColor; }
            set { m_tipsColor = value; }
        }

        [Description("鼠标效果生效时发生，需要和MouseEffected同时使用，否则无效"), Category("自定义")]
        public event EventHandler MouseEffecting;

        [Description("鼠标效果结束时发生，需要和MouseEffecting同时使用，否则无效"), Category("自定义")]
        public event EventHandler MouseEffected;


        public UCBtnExt()
        {
            InitializeComponent();
            this.TabStop = false;
            lblTips.Paint += lblTips_Paint;
            lbl.MouseEnter += lbl_MouseEnter;
            lbl.MouseLeave += lbl_MouseLeave;
        }

        Color m_cacheColor = Color.Empty;
        void lbl_MouseLeave(object sender, EventArgs e)
        {
            if (enabledMouseEffect)
            {
                if (MouseEffecting != null && MouseEffected != null)
                {
                    MouseEffected(this, e);
                }
                else
                {
                    if (m_cacheColor != Color.Empty)
                    {
                        this.FillColor = m_cacheColor;
                        m_cacheColor = Color.Empty;
                    }
                }
            }
        }

        void lbl_MouseEnter(object sender, EventArgs e)
        {
            if (enabledMouseEffect)
            {
                if (MouseEffecting != null && MouseEffected != null)
                {
                    MouseEffecting(this, e);
                }
                else
                {
                    if (FillColor != Color.Empty && FillColor != null)
                    {
                        m_cacheColor = this.FillColor;
                        this.FillColor = this.FillColor.ChangeColor(-0.2f);
                    }
                }
            }
        }


        /// <summary>
        /// Handles the Paint event of the lblTips control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs" /> instance containing the event data.</param>
        void lblTips_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetGDIHigh();
            e.Graphics.FillEllipse(new SolidBrush(m_tipsColor), new Rectangle(0, 0, lblTips.Width - 1, lblTips.Height - 1));
            SizeF sizeEnd = e.Graphics.MeasureString(TipsText, lblTips.Font);

            e.Graphics.DrawString(TipsText, lblTips.Font, new SolidBrush(lblTips.ForeColor), new PointF((lblTips.Width - sizeEnd.Width) / 2, (lblTips.Height - sizeEnd.Height) / 2 + 1));
        }

        /// <summary>
        /// Handles the MouseDown event of the lbl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.BtnClick != null)
                BtnClick(this, e);
        }
    }
}
