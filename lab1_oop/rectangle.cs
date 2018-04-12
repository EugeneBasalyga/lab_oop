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
    public class Rectangle : Figure
    {
        public Point TopLeft;
        public Point BottomRight;


        public override int pointCount { get { return 2; } }

        public Rectangle()
        {
            Color = Color.Black;
            Thikness = 1;
        }

        public Rectangle(List<Point> points) : this()
        {
            TopLeft = points[0];
            BottomRight = points[1];
        }
        public Rectangle(List<Point> points, Color color) : this(points)
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

            var brush = new SolidBrush(Color);
            var rect = new System.Drawing.Rectangle(points[0].X, points[0].Y, points[1].X - points[0].X, points[1].Y - points[0].Y);
            graphics.FillRectangle(brush, rect);
            brush.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            if (TopLeft.IsEmpty || BottomRight.IsEmpty || graphics == null)
                return;


            var pen = new Pen(Color, Thikness);
            var rect = new System.Drawing.Rectangle(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
            graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
    }
}
