namespace CohesionAndCoupling
{
    public class Shape3D
    {
        public Shape3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
    }
}
