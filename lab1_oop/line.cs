using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1_oop
{
    public class Line : Figure
    {
        public Point Start;
        public Point End;
        public Color Color;
        public float Width;

        public override int pointCount { get { return 2; } }

        public Line()
        {
            Color = Color.Black;
            Width = 1;
        }
        public Line(List<Point> points) : this()
        {
            Start = points[0];
            End = points[1];
        }
        public Line(List<Point> points, float width) : this(points)
        {
            Width = width;
        }
        public Line(List<Point> points, float width, Color color) : this(points, width)
        {
            Color = color;
        }

        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points[0].IsEmpty || points[1].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Width);
            graphics.DrawLine(pen, points[0], points[1]);
            pen.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            if (Start.IsEmpty || End.IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Width);
            graphics.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
