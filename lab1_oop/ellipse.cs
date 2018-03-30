using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1_oop
{
    public class Ellipse : Figure
    {
        public Point TopLeft;
        public Point BottomRight;

        public float Width;

        public override int pointCount { get { return 2; } }

        public Ellipse()
        {
            Color = Color.Black;
            Width = 1;
        }

        public Ellipse(List<Point> points) : this()
        {
            TopLeft = points[0];
            BottomRight = points[1];
        }
        public Ellipse(List<Point> points, Color color) : this(points)
        {
            Color = color;
        }

        public override void SetPoints(List<Point> points)
        {
            if (points.Count == pointCount)
            {
                TopLeft = points[0];
                BottomRight = points[1];
            }
        }
        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points[0].IsEmpty || points[1].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Width);
            var rect = new System.Drawing.Rectangle(points[0].X, points[0].Y, points[1].X - points[0].X, points[1].Y - points[0].Y);
            graphics.DrawEllipse(pen, rect);
            pen.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            if (TopLeft.IsEmpty || BottomRight.IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Width);
            var rect = new System.Drawing.Rectangle(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
            graphics.DrawEllipse(pen, rect);
            pen.Dispose();
        }
    }
}
