using System;
using System.Collections.Generic;
using System.Drawing;
using Drawable;

namespace lab1_oop
{
    [Serializable]
    public class Line : Figure
    {
        public Point Start;
        public Point End;

        public override int pointCount { get { return 2; } }

        public Line()
        {
            Color = Color.Black;
            Thikness = 1;
        }
        public Line(List<Point> points) : this()
        {
            Start = points[0];
            End = points[1];
        }
        public Line(List<Point> points, float width) : this(points)
        {
            Thikness = width;
        }
        public Line(List<Point> points, float width, Color color) : this(points, width)
        {
            Color = color;
        }

        public override void SetPoints(List<Point> points)
        {
            if (points.Count == pointCount)
            {
                Start = points[0];
                End = points[1];
            }
        }

        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points[0].IsEmpty || points[1].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Thikness);
            graphics.DrawLine(pen, points[0], points[1]);
            pen.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            if (Start.IsEmpty || End.IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Thikness);
            graphics.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
