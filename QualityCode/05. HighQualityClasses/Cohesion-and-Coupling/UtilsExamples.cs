namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                ShapeUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                ShapeUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Shape3D shape3D = new Shape3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", ShapeUtils.CalcVolume(shape3D));
            Console.WriteLine("Diagonal XYZ = {0:f2}", ShapeUtils.CalcDiagonalXYZ(shape3D));
            Console.WriteLine("Diagonal XY = {0:f2}", ShapeUtils.CalcDiagonalXY(shape3D));
            Console.WriteLine("Diagonal XZ = {0:f2}", ShapeUtils.CalcDiagonalXZ(shape3D));
            Console.WriteLine("Diagonal YZ = {0:f2}", ShapeUtils.CalcDiagonalYZ(shape3D));
        }
    }
}
