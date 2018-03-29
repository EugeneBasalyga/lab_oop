using System.Collections.Generic;
using System.Drawing;

namespace lab1_oop
{
    public class Quadrangle : Triangle
    {
        public Point FourthDot;

        public override int pointCount { get { return 4; } }

        public Quadrangle():base()
        {
            Color = Color.Black;
            Width = 1;
        }

        public Quadrangle(List<Point> points) : this()
        {
            FirstDot = points[0];
            SecDot = points[1];
            ThirdDot = points[2];
            FourthDot = points[3];
        }
        public Quadrangle(List<Point> points, Color color) : this(points)
        {
            Color = color;
        }

        public override void Draw(Graphics graphics)
        {
            if (FirstDot.IsEmpty || FirstDot.IsEmpty || FirstDot.IsEmpty || graphics == null)
                return;


            Point[] currPoints =
            {
                 FirstDot,
                 SecDot,
                 ThirdDot,
                 FourthDot
            };

            var pen = new Pen(Color, Width);
            graphics.DrawPolygon(pen, currPoints);
            pen.Dispose();
        }
    }
}

