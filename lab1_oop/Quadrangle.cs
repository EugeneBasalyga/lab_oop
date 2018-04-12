using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab1_oop
{
    [Serializable]
    public class Quadrangle : Triangle
    {
        public Point FourthDot;

        public override int pointCount { get { return 4; } }

        public Quadrangle():base()
        {
            Color = Color.Black;
            Thikness = 1;
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

        public override void SetPoints(List<Point> points)
        {
            //base.SetPoints(points);
            if (points.Count == pointCount)
            {
                FirstDot = points[0];
                SecDot = points[1];
                ThirdDot = points[2];
                FourthDot = points[3];
            }
        }

        public override void Draw(Graphics graphics)
        {
            if (FirstDot.IsEmpty || SecDot.IsEmpty || ThirdDot.IsEmpty || FourthDot.IsEmpty || graphics == null)
                return;


            Point[] currPoints =
            {
                 FirstDot,
                 SecDot,
                 ThirdDot,
                 FourthDot
            };

            var pen = new Pen(Color, Thikness);
            graphics.DrawPolygon(pen, currPoints);
            pen.Dispose();
        }
    }
}

