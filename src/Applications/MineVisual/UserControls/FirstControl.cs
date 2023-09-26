using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.UserControls
{
    public class FirstControl : System.Windows.Forms.Control
    {
        private ContentAlignment alignmentValue = ContentAlignment.MiddleLeft;

        [Category("对齐"), Description("指定文本对齐方式")]
        public ContentAlignment TextAlignment
        {

            get
            {
                return alignmentValue;
            }
            set
            {
                alignmentValue = value;

                // The Invalidate method invokes the OnPaint method described
                // in step 3.
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
            switch (alignmentValue)
            {
                case ContentAlignment.MiddleLeft:
                    style.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    style.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    style.Alignment = StringAlignment.Center;
                    break;
            }

            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, style);
        }
    }
}
