using System.Collections.Generic;
using System.Drawing;

namespace lab1_oop
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, List<Point> points);
        public virtual int pointCount { get; }
        public Color Color;

        public abstract void SetPoints(List<Point> points);

        public virtual Figure CreateCopy(List<Point> points, Color color)
        {
            var x = (Figure)MemberwiseClone(); //making copy
            x.SetPoints(points); //set field points
            x.Color = color;
            return x;
        }
    }
}
