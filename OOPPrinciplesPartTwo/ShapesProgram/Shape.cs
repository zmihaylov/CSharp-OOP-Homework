namespace ShapesProgram
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double shapeWidth, double shapeHeight)
        {
            this.Width = shapeWidth;
            this.Height = shapeHeight;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value<=0)
                {
                    throw new ArithmeticException("Width has wrong value!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Height has wrong value!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
