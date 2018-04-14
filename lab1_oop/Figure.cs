﻿using System;
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
    public abstract class Figure
    {
        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, List<Point> points);
        public virtual int pointCount { get; }
        public Color Color;
        public Color BrushColor;
        public float Thikness;

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
