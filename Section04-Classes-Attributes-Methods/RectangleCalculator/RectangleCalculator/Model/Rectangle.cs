
namespace RectangleCalculator.Model
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }
    }
}
