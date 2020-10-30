namespace Exercise02
{
    public class Square : Shape
    {
        
        public Square(double side)
        {
            Height = side;
            Width = side;
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