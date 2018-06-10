using System;
using System.Collections.Generic;
using System.Drawing;
using Drawable;

namespace lab1_oop
{
    [Serializable]
    public class CompositFigure
    {
        public Figure Figure;
        public readonly List<Point> Points;

        public CompositFigure(List<Point> points) { Points = points; }
    }
    [Serializable]
    public class UserFigure : Figure
    {
        public string Name;
        public Point TopLeft;

        public List<CompositFigure> UserFigureList = new List<CompositFigure>();
        //protected readonly List<Point> points = new List<Point>();
        public UserFigure(string name) : base()
        {
            Name = name;
        }

        public override string GetName()
        {
            return Name;
        }

        public override int pointCount => 1;

        public override void SetPoints(List<Point> points)
        {
            if (points != null && points.Count > 0)
                TopLeft = points[0];
        }

        public override void Draw(Graphics graphics)
        {
            foreach (var f in UserFigureList)
            {
                var tmpPoint = new List<Point>(f.Points.Count);
                foreach (var p in f.Points)
                {
                    tmpPoint.Add(new Point(p.X + TopLeft.X, p.Y + TopLeft.Y));
                }
                f.Figure.SetPoints(tmpPoint);
                f.Figure.Color = Color;
                f.Figure.Thikness = Thikness;
                f.Figure.BrushColor = BrushColor;
                f.Figure.Draw(graphics);
            }
        }

        public override void Draw(Graphics graphics, List<Point> points)
        {
        }
    }
}
