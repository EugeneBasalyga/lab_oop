using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1_oop
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, List<Point> points);
        public virtual int pointCount { get; }
    }
}
