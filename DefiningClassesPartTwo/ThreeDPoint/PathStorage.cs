namespace ThreeDPoint
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void WritePathFile(string fileLocation,Path path)
        {
            StreamWriter writer = new StreamWriter(fileLocation, false);

            using (writer)
            {
                writer.Write(path);
            }
        }

        public static Path ReadPathFromFile(string fileLocation)
        {
            Path loadedPath = new Path();
            StreamReader reader = new StreamReader(fileLocation);

            using (reader)
            {
                string currentLine = reader.ReadLine();

                while (!string.IsNullOrEmpty(currentLine))
                {
                    currentLine = currentLine.Substring(currentLine.IndexOf("--->") + 4);
                    int[] coord = currentLine.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    loadedPath.AddPoint(coord[0], coord[1], coord[2]);

                    currentLine = reader.ReadLine();
                }

                return loadedPath;
            }
        }
    }
}
