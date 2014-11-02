namespace Euclidian3DSpace
{
    using System.IO;
    using System.Linq;

    public static class Storage
    {
        private const string DefaultDirectory = string.Empty;

        public static void SavePath(Path3D path, string fileName)
        {
            string filePath = DefaultDirectory + fileName;

            StreamWriter writer = new StreamWriter(filePath);

            using (writer)
            {
                foreach (var point in path.Path)
                {
                    writer.WriteLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public static Path3D LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            Path3D result = new Path3D();
            Point3D point;

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    int[] parsedCoords = line.Split(' ').Select(coord => int.Parse(coord)).ToArray();
                    point = new Point3D(parsedCoords[0], parsedCoords[1], parsedCoords[2]);
                    result.AddPoint(point);

                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}
