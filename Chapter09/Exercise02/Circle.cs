using System;

namespace Exercise02
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius 
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                Height = value * 2;
                Width = value * 2;
            }
        }
        
        public Circle(){}
        public Circle(double r)
        {
            Radius = r;
            Height = r * 2;
            Width = r * 2;
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