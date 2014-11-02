//Create a class Path3D to hold a sequence of points in the 3D space. 
//Create a static class Storage with static methods to save and load paths from a text file. 
//Use a file format of your choice. Learn how to read and write text files in Internet. 
//Ensure you close correctly all files with the "using" statement.

namespace Euclidian3DSpace
{
    using System.Collections.Generic;

    public class Path3D
    {
        public Path3D(){
            this.Path = new List<Point3D>();
        }

        public List<Point3D> Path { get; private set; }

        public void AddPoint(Point3D point3D)
        {
            this.Path.Add(point3D);
        }
    }
}
