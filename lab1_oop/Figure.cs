using System.Collections.Generic;
using System.Drawing;

namespace lab1_oop
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, List<Point> points);
        public virtual int pointCount { get; }

        public abstract void SetPoints(List<Point> points);

        public virtual Figure CreateInstance(List<Point> points)
        {
            var x = (Figure)MemberwiseClone();
            x.SetPoints(points);
            return x;
        }
    }
}
