using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.UserControls
{
    public class BaseUserControl : UserControl
    {
        private Color _CustomBackColor = Color.DarkBlue;
        [Category("自定义"), Description("定义控件背景颜色")]
        public Color CustomBackColor
        {
            get { return _CustomBackColor; }
            set
            {
                _CustomBackColor = value;
                this.Refresh();
            }
        }

        private Color _CustomBorderColor;
        [Category("自定义"), Description("定义控件边框颜色")]
        public Color CustomBorderColor
        {
            get { return _CustomBorderColor; }
            set
            {
                _CustomBorderColor = value;
                this.Refresh();
            }
        }

        private Byte _CustomBorderWidth;
        [Category("自定义"), Description("定义控件边框宽度")]
        public Byte CustomBorderWidth
        {
            get { return _CustomBorderWidth; }
            set
            {
                _CustomBorderWidth = value;
                this.Refresh();
            }
        }

        private int _CustomRadius = 1;
        [Category("自定义"), Description("定义控件圆角半径")]
        public int CustomRadius
        {
            get { return _CustomRadius; }
            set
            {
                _CustomRadius = value;
                this.Refresh();
            }
        }

        private string _CustomContent;
        [Category("自定义"), Description("控件内容")]
        public string CustomContent
        {
            get { return _CustomContent; }
            set
            {
                _CustomContent = value;
                this.Refresh();
            }
        }

        private ContentAlignment _CustomContentAlignment = ContentAlignment.MiddleCenter;
        [Category("自定义"), Description("控件内容对齐方式")]
        public ContentAlignment CustomContentAlignment
        {
            get { return _CustomContentAlignment; }
            set
            {
                _CustomContentAlignment = value;
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = GetRoundedRectPath(this.ClientRectangle,_CustomRadius);//new GraphicsPath();
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillPath(new SolidBrush(this._CustomBackColor), graphicsPath);

            if(_CustomRadius > 0)
            {
                e.Graphics.DrawPath(new Pen(_CustomBorderColor,_CustomBorderWidth), graphicsPath);
            }


            if (_CustomBorderWidth > 0)
            {
                e.Graphics.DrawPath(new Pen(new SolidBrush(_CustomBorderColor), this._CustomBorderWidth), graphicsPath);
            }

            if (!string.IsNullOrWhiteSpace(_CustomContent))
            {
                SizeF sizeF = e.Graphics.MeasureString(_CustomContent, this.Font);
                SolidBrush solidBrush = new SolidBrush(this.ForeColor);

                switch (_CustomContentAlignment)
                {
                    case ContentAlignment.MiddleLeft:
                        e.Graphics.DrawString(_CustomContent, this.Font, solidBrush, this.Padding.Left, (this.Height - sizeF.Height) / 2);
                        break;
                    case ContentAlignment.MiddleCenter:
                        e.Graphics.DrawString(_CustomContent, this.Font, solidBrush, (this.Width - sizeF.Width) / 2, (this.Height - sizeF.Height) / 2);
                        break;
                    case ContentAlignment.MiddleRight:
                        e.Graphics.DrawString(_CustomContent, this.Font, solidBrush, this.Width - sizeF.Width - this.Padding.Right, (this.Height - sizeF.Height) / 2);
                        break;
                    default: break;
                }
            }

            base.OnPaint(e);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect,int radius) 
        {
            Rectangle rectangle = new Rectangle(rect.Location,new Size(radius,radius));

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            graphicsPath.AddArc(rectangle, 180, 90);
            rectangle.X = rect.Right - radius;

            graphicsPath.AddArc(rectangle, 270, 90);
            rectangle.Y = rect.Bottom - radius;

            graphicsPath.AddArc(rectangle, 360, 90);
            rectangle.X = rect.Left;

            graphicsPath.AddArc(rectangle, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;

        }
    }
}
