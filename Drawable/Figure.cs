using System;
using System.Collections.Generic;
using System.Drawing;



namespace Drawable
{
    [Serializable]
    public abstract class Figure
    {
        public Color Color { get; set; }
        public Color BrushColor { get; set; }
        public float Thikness { get; set; }

        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, List<Point> points);
        public virtual int pointCount { get; }

        public abstract void SetPoints(List<Point> points);

        public virtual Figure CreateCopy(List<Point> points, Color color, float thikness, Color brushcolor)
        {
            var x = (Figure)MemberwiseClone(); //making copy
            x.SetPoints(points); //set field points
            x.Color = color;
            x.Thikness = thikness;
            if (brushcolor != Color.White)
                x.BrushColor = brushcolor;
            return x;
        }


    }

}

