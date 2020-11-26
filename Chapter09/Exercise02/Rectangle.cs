namespace Exercise02
{
    public class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }
}