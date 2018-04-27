using System;
using System.Collections.Generic;
using System.Drawing;
using Drawable;

namespace lab1_oop
{
    [Serializable]
    public class Circle : Figure
    {
        public Point TopLeft;
        public Point BottomRight;


        public override int pointCount { get { return 2; } }

        public Circle()
        {
            Color = Color.Black;
            Thikness = 1;
        }

        public Circle(List<Point> points) : this()
        {
            TopLeft = points[0];
            BottomRight = points[1];
        }
        public Circle(List<Point> points, Color color) : this(points)
        {
            Color = color;
        }

        public override void SetPoints(List<Point> points)
        {
            int tmp;
            if (points.Count == pointCount)
            {
                TopLeft = points[0];
                BottomRight = points[1];
                if (TopLeft.X > BottomRight.X)
                {
                    tmp = TopLeft.X;
                    TopLeft.X = BottomRight.X;
                    BottomRight.X = tmp;
                }
                if (TopLeft.Y > BottomRight.Y)
                {
                    tmp = TopLeft.Y;
                    TopLeft.Y = BottomRight.Y;
                    BottomRight.Y = tmp;
                }
            }
        }

        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points[0].IsEmpty || points[1].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Thikness);
            int radius = GetHypo(points[1].X - points[0].X, points[1].Y - points[0].Y);
            graphics.DrawEllipse(pen, points[0].X - radius, points[0].Y - radius, radius * 2, radius * 2);
            pen.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            if (TopLeft.IsEmpty || BottomRight.IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Thikness);
            SolidBrush brush = new SolidBrush(BrushColor);

            int radius = GetHypo(BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
            graphics.DrawEllipse(pen, TopLeft.X - radius, TopLeft.Y - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, TopLeft.X - radius, TopLeft.Y - radius, radius * 2, radius * 2);
            pen.Dispose();
            brush.Dispose();
        }

        private int GetHypo(int a, int b)
        {
            return (int)Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
        }
    }
}
