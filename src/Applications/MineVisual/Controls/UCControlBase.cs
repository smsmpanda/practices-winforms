#nullable disable
using MineVisual.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineVisual.Controls
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class UCControlBase : UserControl, IContainerControl
    {
        /// <summary>
        /// The is radius
        /// </summary>
        private bool _isRadius = false;

        /// <summary>
        /// The corner radius
        /// </summary>
        private int _cornerRadius = 24;

        /// <summary>
        /// The is show rect
        /// </summary>
        private bool _isShowRectBorder = false;

        /// <summary>
        /// The rect color
        /// </summary>
        private Color _rectColor = Color.FromArgb(220, 220, 220);

        /// <summary>
        /// The rect width
        /// </summary>
        private int _rectWidth = 1;

        /// <summary>
        /// The fill color
        /// </summary>
        private Color _fillColor = Color.Transparent;


        [Category("自定义"), Description("是否圆角")]
        public virtual bool IsRadius
        {
            get => _isRadius;
            set
            {
                _isRadius = value;
                Refresh();
            }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        /// <value>The color of the rect.</value>
        [Description("边框颜色"), Category("自定义")]
        public virtual Color RectBorderColor
        {
            get => _rectColor;
            set
            {
                _rectColor = value;
                this.Refresh();
            }
        }

        /// <summary>
        /// 边框宽度
        /// </summary>
        /// <value>The width of the rect.</value>
        [Description("边框宽度"), Category("自定义")]
        public virtual int RectBorderWidth
        {
            get => _rectWidth;
            set
            {
                _rectWidth = value;
                Refresh();
            }
        }

        /// <summary>
        /// 当使用边框时填充颜色，当值为背景色或透明色或空值则不填充
        /// </summary>
        /// <value>The color of the fill.</value>
        [Description("当使用边框时填充颜色，当值为背景色或透明色或空值则不填充"), Category("自定义")]
        public virtual Color FillColor
        {
            get => _fillColor;
            set
            {
                _fillColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 圆角角度
        /// </summary>
        /// <value>The coner radius.</value>
        [Description("圆角角度"), Category("自定义")]
        public virtual int ConerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = Math.Max(value, 1);
                Refresh();
            }
        }

        /// <summary>
        /// 是否显示边框
        /// </summary>
        /// <value><c>true</c> if this instance is show rect; otherwise, <c>false</c>.</value>
        [Description("是否显示边框"), Category("自定义")]
        public virtual bool IsShowRectBorder
        {
            get => _isShowRectBorder;
            set
            {
                _isShowRectBorder = value;
                Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Visible)
            {
                if (IsRadius)
                {
                    this.SetWindowRegion();
                }
                else
                {
                    //关闭圆角后显示为原矩形
                    GraphicsPath g = new GraphicsPath();
                    g.AddRectangle(base.ClientRectangle);
                    g.CloseFigure();
                    base.Region = new Region(g);
                }

                GraphicsPath graphicsPath = new GraphicsPath();
                if (_isShowRectBorder || (_fillColor != Color.Empty && _fillColor != Color.Transparent && _fillColor != this.BackColor))
                {
                    Rectangle clientRectangle = base.ClientRectangle;
                    if (_isRadius)
                    {
                        graphicsPath.AddArc(0, 0, _cornerRadius, _cornerRadius, 180f, 90f);
                        graphicsPath.AddArc(clientRectangle.Width - _cornerRadius - 1, 0, _cornerRadius, _cornerRadius, 270f, 90f);
                        graphicsPath.AddArc(clientRectangle.Width - _cornerRadius - 1, clientRectangle.Height - _cornerRadius - 1, _cornerRadius, _cornerRadius, 0f, 90f);
                        graphicsPath.AddArc(0, clientRectangle.Height - _cornerRadius - 1, _cornerRadius, _cornerRadius, 90f, 90f);
                        graphicsPath.CloseFigure();
                    }
                    else
                    {
                        graphicsPath.AddRectangle(clientRectangle);
                    }
                }
                e.Graphics.SetGDIHigh();
                if (_fillColor != Color.Empty && _fillColor != Color.Transparent && _fillColor != this.BackColor)
                    e.Graphics.FillPath(new SolidBrush(_fillColor), graphicsPath);
                if (_isShowRectBorder)
                {
                    Color rectColor = _rectColor;
                    Pen pen = new Pen(rectColor, (float)_rectWidth);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            base.OnPaint(e);
        }

        /// <summary>
        /// Sets the window region.
        /// </summary>
        private void SetWindowRegion()
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(-1, -1, base.Width + 1, base.Height);
            path = this.GetRoundedRectPath(rect, _cornerRadius);
            base.Region = new Region(path);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            Rectangle rect2 = new Rectangle(rect.Location, new Size(radius, radius));
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rect2, 180f, 90f);//左上角
            rect2.X = rect.Right - radius;
            graphicsPath.AddArc(rect2, 270f, 90f);//右上角
            rect2.Y = rect.Bottom - radius;
            rect2.Width += 1;
            rect2.Height += 1;
            graphicsPath.AddArc(rect2, 360f, 90f);//右下角           
            rect2.X = rect.Left;
            graphicsPath.AddArc(rect2, 90f, 90f);//左下角
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        public UCControlBase()
        {
            this.InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
#nullable restore