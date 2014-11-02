namespace CohesionAndCoupling
{
    using System;

    public static class ShapeUtils
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume(Shape3D shape)
        {
            double volume = shape.Width * shape.Height * shape.Depth;

            return volume;
        }

        public static double CalcDiagonalXYZ(Shape3D shape)
        {
            double distance = CalcDistance3D(0, 0, 0, shape.Width, shape.Height, shape.Depth);
            return distance;
        }

        public static double CalcDiagonalXY(Shape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Height);
            return distance;
        }

        public static double CalcDiagonalXZ(Shape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Depth);
            return distance;
        }

        public static double CalcDiagonalYZ(Shape3D shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Height, shape.Depth);
            return distance;
        }
    }
}
