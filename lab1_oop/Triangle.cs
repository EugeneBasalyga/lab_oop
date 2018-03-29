﻿using System.Collections.Generic;
using System.Drawing;

namespace lab1_oop
{
    public class Triangle : Figure
    {
        public Point FirstDot;
        public Point SecDot;
        public Point ThirdDot;
        public Color Color;
        public float Width;

        public override int pointCount { get { return 3; } }
    
        public Triangle()
        {
            Color = Color.Black;
            Width = 1;
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

        public override void Draw(Graphics graphics, List<Point> points)
        {
            if (points.Count != pointCount || points[0].IsEmpty || points[1].IsEmpty || points[2].IsEmpty || graphics == null)
                return;

            var pen = new Pen(Color, Width);
            graphics.DrawPolygon(pen, points.ToArray());
            pen.Dispose();
        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, new List<Point>(new [] { FirstDot, SecDot, ThirdDot }));
        }
    }
}
