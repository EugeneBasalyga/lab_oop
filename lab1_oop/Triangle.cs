using System;
using System.Collections.Generic;
using System.Drawing;
using Drawable;

namespace lab1_oop
{
    [Serializable]
    public class Triangle : Figure
    {
        public Point FirstDot;
        public Point SecDot;
        public Point ThirdDot;


        public override int pointCount { get { return 3; } }
    
        public Triangle()
        {
            Color = Color.Black;
            Thikness = 1;
        }

        public Triangle(List<Point> points) : this()
        {
            FirstDot = points[0];
            SecDot = points[1];
            ThirdDot = points[2];
        }
        public Triangle(List<Point> points, Color color) : this(points)
        {
            Color = color;
        }

        public override void SetPoints(List<Point> points)
        {
            if (points.Count == pointCount)
            {
                FirstDot = points[0];
                SecDot = points[1];
                ThirdDot = points[2];
            }
        }

        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points.Count != pointCount || points[0].IsEmpty || points[1].IsEmpty || points[2].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Thikness);
            SolidBrush brush = new SolidBrush(BrushColor);

            graphics.DrawPolygon(pen, points.ToArray());
            graphics.FillPolygon(brush, points.ToArray());
            pen.Dispose();
            brush.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, new List<Point>(new [] { FirstDot, SecDot, ThirdDot }));
        }
    }
}

