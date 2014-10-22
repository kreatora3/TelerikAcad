namespace  Points3d
{
    /* 03.Write a static class with a static method to calculate the distance between two points in the 3D space. */
   
    using System;
    public static class CalculatingDistance
    {
        public static double Between(Point3D a, Point3D b)
        { 
            double x = a.X- b.X;
            double y = a.Y - b.Y;
            double z = a.Z - b.Z;

            double distance = Math.Sqrt((x * x + y * y + z * z));
            return distance;
        }
    }
}
