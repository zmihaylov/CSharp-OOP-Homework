namespace ShapesProgram
{
    using System;

    public class ShapesProgramMain
    {
        static void Main()
        {
            var shapes = new Shape[]
            {
                new Circle(3.14),
                new Triangle(6,8),
                new Rectangle(7.9,3.98),
                new Circle(2),
                new Rectangle(5,9),
                new Triangle(8,7)
            };

            foreach (var shape in shapes)
            {
                Console.Write(shape.GetType().Name + " ---> ");
                Console.WriteLine("Surface is: {0:F3}", shape.CalculateSurface());
            }
        }
    }
}
