//Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. 
//Search in Internet how to calculate distance in the 3D Euclidian space.

namespace Euclidian3DSpace
{
    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistanceBetween3DPoints(Point3D firstPoint, Point3D secongPoint)
        {
            double distance = Math.Sqrt(
                Math.Pow(secongPoint.X - firstPoint.X, 2) + 
                Math.Pow(secongPoint.Y - firstPoint.Y, 2) + 
                Math.Pow(secongPoint.Z - firstPoint.Z, 2)
                );

            return distance;
        }
    }
}
