using MineVisual.Controls;
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

namespace MineVisual
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //GDICloseFigure(e);

            //GDIAddArc(e);

            //AddBezierExample(e);

            //AddClosedCurveExample(e);

            //AddCurveExample(e);

            //AddEllipseExample(e);

            //AddLineExample(e);

            //AddLinesExample(e);

            //AddPathExample(e);

            //AddPieExample(e);

            //AddPolygonExample(e);

            //AddRectangleExample(e);

            //AddRectanglesExample(e);

            //AddStringExample(e);

            //CloseAllFiguresExample(e);

            //FlattenExample(e);

            //GetBoundsExample(e);

            //GetLastPointExample(e);

            //WidenExample(e);

            //GDIDrawRectangle(e);

            AddArcExample(e);
        }

        private void AddArcExample(PaintEventArgs e)
        {
            // Create a GraphicsPath object.
            GraphicsPath myPath = new GraphicsPath();

            // Set up and call AddArc, and close the figure.
            Rectangle rect = new Rectangle(500, 500, 300, 80);
            //myPath.AddArc(rect, 180, 90);
            //myPath.AddArc(rect, 270, 90);
            //myPath.AddArc(rect, 360, 90);
            //myPath.AddArc(rect, 90, 90);

            var s = rect.Location;
            var s1 = rect.X;
            var s2 = rect.Y;
            var s6 = rect.Top;
            var s3 = rect.Right;
            var s4 = rect.Bottom;
            var s5 = rect.Left;

            myPath = GetRoundedRectPath(rect, 10);

            // Draw the path to screen.
            //e.Graphics.FillRectangle(new SolidBrush(Color.Black), rect);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillPath(new SolidBrush(Color.Blue), myPath);
            e.Graphics.DrawPath(new Pen(Color.Red, 1), myPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            Rectangle rectangle = new Rectangle(rect.Location, new Size(radius, radius));

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rectangle, 180, 90);
            rectangle.X = rect.Right - radius;

            graphicsPath.AddArc(rectangle, 270f, 90f);
            rectangle.Y = rect.Bottom - radius;

            graphicsPath.AddArc(rectangle, 360f, 90f);
            rectangle.X = rect.Left;

            graphicsPath.AddArc(rectangle, 90f, 90f);
            graphicsPath.CloseFigure();

            return graphicsPath;

        }

        private void GDIDrawRectangle(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rectangle = new Rectangle(5, 0, 100, 90);
            path.AddRectangle(rectangle);
            //e.Graphics.FillRectangle(new SolidBrush(Color.DarkRed), rectangle);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Orange), 2), rectangle);

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, Color.Red, Color.Blue, LinearGradientMode.Vertical);
            e.Graphics.FillPath(linearGradientBrush, path);
        }

        private void WidenExample(PaintEventArgs e)
        {

            // Create a path and add two ellipses.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 100, 100);
            myPath.AddEllipse(100, 0, 100, 100);

            // Draw the original ellipses to the screen in black.
            e.Graphics.DrawPath(Pens.Black, myPath);

            // Widen the path.
            Pen widenPen = new Pen(Color.Black, 10);
            Matrix widenMatrix = new Matrix();
            widenMatrix.Translate(50, 50);
            myPath.Widen(widenPen, widenMatrix, 1.0f);

            // Draw the widened path to the screen in red.
            e.Graphics.FillPath(new SolidBrush(Color.Red), myPath);
        }

        public void GetBoundsExample(PaintEventArgs e)
        {

            // Create path number 1 and a Pen for drawing.
            GraphicsPath myPath = new GraphicsPath();
            Pen pathPen = new Pen(Color.Black, 1);

            // Add an Ellipse to the path and Draw it (circle in start

            // position).
            myPath.AddEllipse(20, 20, 100, 100);
            e.Graphics.DrawPath(pathPen, myPath);

            // Get the path bounds for Path number 1 and draw them.
            RectangleF boundRect = myPath.GetBounds();
            e.Graphics.DrawRectangle(new Pen(Color.Red, 1),
                boundRect.X,
                boundRect.Y,
                boundRect.Height,
                boundRect.Width);

            // Create a second graphics path and a wider Pen.
            GraphicsPath myPath2 = new GraphicsPath();
            Pen pathPen2 = new Pen(Color.Black, 10);

            // Create a new ellipse with a width of 10.
            myPath2.AddEllipse(150, 20, 100, 100);
            myPath2.Widen(pathPen2);
            e.Graphics.FillPath(Brushes.Black, myPath2);

            // Get the second path bounds.
            RectangleF boundRect2 = myPath2.GetBounds();

            // Draw the bounding rectangle.
            e.Graphics.DrawRectangle(new Pen(Color.Red, 1),
                boundRect2.X,
                boundRect2.Y,
                boundRect2.Height,
                boundRect2.Width);

            // Display the rectangle size.
            MessageBox.Show(boundRect2.ToString());
        }

        private void GetLastPointExample(PaintEventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddLine(20, 20, 100, 20);
            PointF lastPoint = myPath.GetLastPoint();
            if (lastPoint.IsEmpty == false)
            {
                string lastPointXString = lastPoint.X.ToString();
                string lastPointYString = lastPoint.Y.ToString();
                MessageBox.Show(lastPointXString + ", " + lastPointYString);
            }
            else
            {
                MessageBox.Show("lastPoint is empty");
            }
        }

        private void FlattenExample(PaintEventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            Matrix translateMatrix = new Matrix();
            translateMatrix.Translate(0, 10);
            Point point1 = new Point(20, 100);
            Point point2 = new Point(70, 10);
            Point point3 = new Point(130, 200);
            Point point4 = new Point(180, 100);
            Point[] points = { point1, point2, point3, point4 };
            myPath.AddCurve(points);
            e.Graphics.DrawPath(new Pen(Color.Black, 2), myPath);
            myPath.Flatten(translateMatrix, 10f);
            e.Graphics.DrawPath(new Pen(Color.Red, 1), myPath);
        }

        private void CloseAllFiguresExample(PaintEventArgs e)
        {

            // Create a path containing several open-ended figures.
            GraphicsPath myPath = new GraphicsPath();
            myPath.StartFigure();
            myPath.AddLine(new Point(10, 10), new Point(150, 10));
            myPath.AddLine(new Point(150, 10), new Point(10, 150));
            myPath.StartFigure();
            myPath.AddArc(200, 200, 100, 100, 0, 90);
            myPath.StartFigure();
            Point point1 = new Point(300, 300);
            Point point2 = new Point(400, 325);
            Point point3 = new Point(400, 375);
            Point point4 = new Point(300, 400);
            Point[] points = { point1, point2, point3, point4 };
            myPath.AddCurve(points);

            // Close all the figures.
            myPath.CloseAllFigures();

            // Draw the path to the screen.
            e.Graphics.DrawPath(new Pen(Color.Black, 3), myPath);
        }

        private void AddStringExample(PaintEventArgs e)
        {

            // Create a GraphicsPath object.
            GraphicsPath myPath = new GraphicsPath();

            // Set up all the string parameters.
            string stringText = "Sample Text";
            FontFamily family = new FontFamily("Arial");
            int fontStyle = (int)FontStyle.Italic;
            int emSize = 26;
            Point origin = new Point(20, 20);
            StringFormat format = StringFormat.GenericDefault;

            // Add the string to the path.
            myPath.AddString(stringText,
                family,
                fontStyle,
                emSize,
                origin,
                format);

            //Draw the path to the screen.
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillPath(Brushes.Black, myPath);
        }

        private void AddRectanglesExample(PaintEventArgs e)
        {

            // Adds a pattern of rectangles to a GraphicsPath object.
            GraphicsPath myPath = new GraphicsPath();
            Rectangle[] pathRects =
                     {
                 new Rectangle(20,20,100,200),
                 new Rectangle(40,40,120,220),
                 new Rectangle(60,60,240,140)
             };
            myPath.AddRectangles(pathRects);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddRectangleExample(PaintEventArgs e)
        {

            // Create a GraphicsPath object and add a rectangle to it.
            GraphicsPath myPath = new GraphicsPath();
            Rectangle pathRect = new Rectangle(20, 20, 100, 200);
            myPath.AddRectangle(pathRect);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddPolygonExample(PaintEventArgs e)
        {

            // Create an array of points.
            Point[] myArray =
                     {
                 new Point(23, 20),
                 new Point(40, 10),
                 new Point(57, 20),
                 new Point(50, 40),
                 new Point(30, 40)
             };

            // Create a GraphicsPath object and add a polygon.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(myArray);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddPieExample(PaintEventArgs e)
        {

            // Create a pie slice of a circle using the AddPie method.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPie(20, 20, 70, 70, -45, 135);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(myPen, myPath);
        }
        private void AddPathExample(PaintEventArgs e)
        {

            // Create the first pathright side up triangle.
            Point[] myArray =
                     {
                 new Point(30,30),
                 new Point(60,60),
                 new Point(0,60),
                 new Point(30,30)
             };
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddLines(myArray);

            // Create the second pathinverted triangle.
            Point[] myArray2 =
                     {
                 new Point(30,30),
                 new Point(0,0),
                 new Point(60,0),
                 new Point(30,30)
             };
            GraphicsPath myPath2 = new GraphicsPath();
            myPath2.AddLines(myArray2);

            // Add the second path to the first path.
            myPath.AddPath(myPath2, false);

            // Draw the combined path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        /// <summary>
        /// 向当前图形追加一段椭圆弧。
        /// </summary>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void GDIAddArc(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle rectangle = new Rectangle(400, 300, 120, 60);
            //path.StartFigure();
            path.AddArc(rectangle, 0, 270);
            //path.CloseFigure();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), rectangle);
            e.Graphics.DrawPath(new Pen(Color.Red, 2), path);
        }

        /// <summary>
        /// 闭合当前图形并开始新的图形。 如果当前图形包含一系列相互连接的直线和曲线，该方法通过连接一条从终结点到起始点的直线，闭合该环回。
        /// </summary>
        /// <param name="e"></param>
        private void GDICloseFigure(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(10, 10), new Point(200, 10));
            path.AddLine(new Point(200, 10), new Point(200, 200));
            path.CloseFigure();

            e.Graphics.DrawPath(new Pen(new SolidBrush(Color.Red), 2), path);
        }

        private void AddBezierExample(PaintEventArgs e)
        {

            //// Create a new Path.
            //GraphicsPath myPath = new GraphicsPath();

            //// Call AddBezier.
            //myPath.StartFigure();
            //myPath.AddBezier(50, 50, 70, 72, 100, 160, 150, 150);

            //// Close the curve.
            //myPath.CloseFigure();

            //// Draw the path to screen.
            //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.DrawPath(new Pen(Color.Red, 2), myPath);

            Point[] myArray =
            {
                 new Point(20, 100),
                 new Point(40, 75),
                 new Point(60, 125),
                 new Point(80, 100),
                 new Point(100, 50),
                 new Point(120, 150),
                 new Point(140, 100)
             };

            // Create the path and add the curves.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddBeziers(myArray);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddClosedCurveExample(PaintEventArgs e)
        {

            // Creates a symetrical, closed curve.
            Point[] myArray =
                     {
                 new Point(20,100),
                 new Point(40,150),
                 new Point(60,125),
                 new Point(40,100),
                 new Point(60,75),
                 new Point(40,50)
             };

            // Create a new path and add curve.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddClosedCurve(myArray, .5f);
            Pen myPen = new Pen(Color.Black, 2);

            // Draw the path to screen.
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddCurveExample(PaintEventArgs e)
        {

            // Create some points.
            Point point5 = new Point(0, 0);
            Point point1 = new Point(20, 20);
            Point point2 = new Point(40, 10);
            Point point3 = new Point(60, 5);
            Point point4 = new Point(80, 10);

            // Create an array of the points.
            Point[] curvePoints = { point5, point1, point2, point3, point4 };

            // Create a GraphicsPath object and add a curve.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddCurve(curvePoints, 0, 1, 1f);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 1);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddEllipseExample(PaintEventArgs e)
        {

            // Create a path and add an ellipse.
            Rectangle myEllipse = new Rectangle(20, 20, 50, 50);
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(myEllipse);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddLineExample(PaintEventArgs e)
        {

            //Create a path and add a symetrical triangle using AddLine.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddLine(30, 30, 60, 60);
            myPath.AddLine(60, 60, 0, 60);
            myPath.AddLine(0, 60, 30, 30);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void AddLinesExample(PaintEventArgs e)
        {

            // Create a symetrical triangle using an array of points.
            Point[] myArray =
                     {
                 new Point(30,30),
                 new Point(60,60),
                 new Point(0,60),
                 new Point(30,30)
             };

            //Create a path and add lines.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddLines(myArray);

            // Draw the path to the screen.
            Pen myPen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(myPen, myPath);
        }

        private void baseButton1_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult dialog = loginForm.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                loginForm.Close();
            }
        }
    }
}
