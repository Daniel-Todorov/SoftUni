//Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Create appropriate constructors. 
//Implement the ToString() to enable printing a 3D point.
//Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint {0, 0, 0}. 
//Add a static property to return the starting point.

namespace Euclidian3DSpace
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Point3D StartingPoint
        {
            get
            {
                return Point3D.startingPoint;
            }
        }

        public override string ToString()
        {
            string result = string.Format("X: {0}; Y: {1}; Z: {2}", this.X, this.Y, this.Z);

            return result;
        }
    }
}
