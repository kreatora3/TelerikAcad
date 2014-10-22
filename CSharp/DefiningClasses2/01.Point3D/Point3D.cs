namespace Points3d
{
    /*
     01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
     Implement the ToString() to enable printing a 3D point.
     
     02.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
     Add a static property to return the point O.
    */

    using System;
    public struct Point3D
    {
        // Fields
        private static readonly Point3D point0 = new Point3D();
       
        // Constructor
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
       
        // Properties
        public static Point3D PointZero
        {
            get { return point0; }
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
       
       
        //Methods
        public override string ToString()
        {
            return string.Format("This point has x[{0}], y[{1}], z[{2}] coordinates", X, Y, Z);
        }
    }
}
