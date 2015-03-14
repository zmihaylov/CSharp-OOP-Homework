namespace ShapesProgram
{
    public class Rectangle : Shape
    {
        public Rectangle(double rectWidth, double rectHeight)
            : base(rectWidth, rectHeight)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
