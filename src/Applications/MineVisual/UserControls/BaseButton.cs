using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.UserControls
{
    [DefaultEvent(nameof(ButtonClick))]
    public class BaseButton : BaseUserControl
    {
        [Category("自定义"), Description("按钮点击事件")]
        public event EventHandler ButtonClick;

        protected override void OnClick(EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
            base.OnClick(e);
        }


        [Category("自定义"), Description("鼠标移动至控件上方时背景色")]
        private Color _CustomMouseEnterBackColor = Color.Red;
        public Color CustomMouseEnterBackColor
        {
            get { return _CustomMouseEnterBackColor; }
            set
            {
                _CustomMouseEnterBackColor = value;
                this.Refresh();
            }
        }

        Color oldBgColor = Color.Empty;
        protected override void OnMouseEnter(EventArgs e)
        {
            oldBgColor = this.CustomBackColor;
            this.CustomBackColor = _CustomMouseEnterBackColor;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.CustomBackColor = oldBgColor;
            base.OnMouseLeave(e);
        }
    }
}
