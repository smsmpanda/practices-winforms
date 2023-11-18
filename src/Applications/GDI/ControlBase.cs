using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class UserControlBase : UserControl
    {
        public UserControlBase()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SetStyle(ControlStyles.ResizeRedraw, true);

            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            Size = new System.Drawing.Size(120, 50);
            BackColor = Color.Transparent;
        }

        private int _extRadius = 5;                         //控件圆角尺寸
        private Color _extFillColor = Color.Transparent;    //控件背景颜色填充
        private Color _extBorderColor = Color.Transparent;  //控件边框颜色
        private int _extBorderWidth;                        //控件边框宽度

        public int ExtRadius
        {
            get { return _extRadius; }
            set
            {
                _extRadius = value;
                Invalidate();
            }
        }

        public virtual Color ExtFillColor
        {
            get => _extFillColor;
            set
            {
                _extFillColor = value;
                Invalidate();
            }
        }

        public Color ExtBorderColor
        {
            get => _extBorderColor;
            set
            {
                _extBorderColor = value;
                Invalidate();
            }
        }

        public int ExtBorderWidth
        {
            get => _extBorderWidth;
            set
            {
                _extBorderWidth = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!this.Visible) 
            {
                return;
            }

            //设置控件可见区域
            this.SetWindowRegion();

            //开启绘制路径
            GraphicsPath graphicsPath = new GraphicsPath();
            if (_extRadius > 0)
            {
                Rectangle clientRectangle = base.ClientRectangle;
                graphicsPath.AddArc(0, 0, _extRadius, _extRadius, 180f, 90f);
                graphicsPath.AddArc(clientRectangle.Width - _extRadius - 1, 0, _extRadius, _extRadius, 270f, 90f);
                graphicsPath.AddArc(clientRectangle.Width - _extRadius - 1, clientRectangle.Height - _extRadius - 1, _extRadius, _extRadius, 0f, 90f);
                graphicsPath.AddArc(0, clientRectangle.Height - _extRadius - 1, _extRadius, _extRadius, 90f, 90f);
                graphicsPath.CloseFigure();
            }
            else 
            {
                graphicsPath.AddRectangle(base.ClientRectangle);
            }


            //使绘图质量最高，即消除锯齿
            e.Graphics.SetGDIHigh();

            if (_extFillColor != Color.Empty && _extFillColor != BackColor && _extFillColor != Color.Transparent)
            {
                e.Graphics.FillPath(new SolidBrush(_extFillColor), graphicsPath);
            }

            if (_extBorderWidth > 0)
            {
                Color rectColor = _extBorderColor;
                Pen pen = new Pen(rectColor, (float)_extBorderWidth);
                e.Graphics.DrawPath(pen, graphicsPath);
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// //控件可见区域设置
        /// </summary>
        private void SetWindowRegion()
        {
            if (_extRadius <= 0)
            {
                //关闭圆角后显示为原矩形
                GraphicsPath g = new GraphicsPath();
                g.AddRectangle(base.ClientRectangle);
                g.CloseFigure();
                base.Region = new Region(g);
            }
            else
            {
                GraphicsPath path = new GraphicsPath();
                Rectangle rect = new Rectangle(-1, -1, base.Width + 1, base.Height);
                path = this.GetRoundedRectPath(rect, _extRadius);
                base.Region = new Region(path);
            }
        }

        /// <summary>
        /// 获取圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            Rectangle rect2 = new Rectangle(rect.Location, new Size(radius, radius));
            GraphicsPath gpth = new GraphicsPath();
            gpth.AddArc(rect2, 180f, 90f);//左上角

            rect2.X = rect.Right - radius;
            gpth.AddArc(rect2, 270f, 90f);//右上角

            rect2.Y = rect.Bottom - radius;
            rect2.Width += 1;
            rect2.Height += 1;
            gpth.AddArc(rect2, 360f, 90f);//右下角    

            //左下角
            rect2.X = rect.Left;
            gpth.AddArc(rect2, 90f, 90f);
            gpth.CloseFigure();

            return gpth;
        }
    }
}
