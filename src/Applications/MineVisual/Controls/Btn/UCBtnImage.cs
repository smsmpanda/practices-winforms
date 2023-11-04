using System.ComponentModel;

namespace MineVisual.Controls.Btn
{
    public partial class UCBtnImage : UCBtnExt
    {
        /// <summary>
        /// The BTN text
        /// </summary>
        private string _btnText = "自定义按钮";
        /// <summary>
        /// 按钮文字
        /// </summary>
        /// <value>The BTN text.</value>
        [Description("按钮文字"), Category("自定义")]
        public override string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                lbl.Text = value;
                lbl.Refresh();
            }
        }
        /// <summary>
        /// 图片
        /// </summary>
        /// <value>The image.</value>
        [Description("图片"), Category("自定义")]
        public virtual Image Image
        {
            get
            {
                return this.lbl.Image;
            }
            set
            {
                this.lbl.Image = value;
            }
        }

        /// <summary>
        /// 图片位置
        /// </summary>
        /// <value>The image align.</value>
        [Description("图片位置"), Category("自定义")]
        public virtual ContentAlignment ImageAlign
        {
            get { return this.lbl.ImageAlign; }
            set { lbl.ImageAlign = value; }
        }
        /// <summary>
        /// 文字位置
        /// </summary>
        /// <value>The text align.</value>
        [Description("文字位置"), Category("自定义")]
        public virtual ContentAlignment TextAlign
        {
            get { return this.lbl.TextAlign; }
            set { lbl.TextAlign = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UCBtnImg" /> class.
        /// </summary>
        public UCBtnImage()
        {
            InitializeComponent();
            IsShowTips = false;
            base.BtnForeColor = ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            base.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            base.BtnText = "自定义按钮";
        }
    }
}
