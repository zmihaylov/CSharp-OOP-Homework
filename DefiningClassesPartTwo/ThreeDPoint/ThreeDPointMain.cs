namespace ThreeDPoint
{
    using System;

    public class ThreeDPointMain
    {
        static void Main()
        {
            Point3D first = new Point3D(3, 4, 5);
            Point3D second = new Point3D(9, 8, 7);
            Point3D third = Point3D.Start;
            Console.WriteLine(third);

            double distance = Distance.CalculateDistance(first, second);
            Console.WriteLine(distance);

            Path path = new Path();
            path.AddPoint(first);
            path.AddPoint(second);
            Console.WriteLine(path);

            PathStorage.WritePathFile(@"..\..\test.txt", path);

            Path newPath = PathStorage.ReadPathFromFile(@"..\..\testLoadMethod.txt");

            Console.WriteLine(newPath);
        }
    }
}
