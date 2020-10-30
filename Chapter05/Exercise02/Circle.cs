using System;

namespace Exercise02
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = radius * 2;
            Width = radius * 2;
        }

        public override double Area
        {
            get
            {
                double radius = Height / 2;
                return Math.PI * radius * radius;
            }
        }
    }
}