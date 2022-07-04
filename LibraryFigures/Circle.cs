using System;

namespace LibraryFigures
{
    public class Circle : Figure
    {
        private int Radius { get; set; }
        public Circle(string typeFigure, int radius) : base(typeFigure)
        {
            Radius = radius;
        }
        public override double Square()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }

}
