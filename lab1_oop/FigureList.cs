using System.Collections.Generic;
using Drawable;

namespace lab1_oop
{  
    public static class FigureList
    {
        //public static Rectangle rectangle = new Rectangle();
        public static Line line = new Line();
        //public static Ellipse ellipse = new Ellipse();
        public static Triangle triangle = new Triangle();
        public static Circle circle = new Circle();
        public static Quadrangle quadrangle = new Quadrangle();

        public static readonly List<Figure> figures = new List<Figure>();


        static FigureList()
        {
            figures.Add(line);
            //figures.Add(rectangle);
            //figures.Add(ellipse);
            figures.Add(circle);
            figures.Add(triangle);
            figures.Add(quadrangle);
        }
    }
}
