using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3d
{
    class Program
    {
        static void Main()
        {
            // Problem 01, 02
            Point3D point = new Point3D(3,3,5);
            Console.WriteLine(point);
            
            Console.WriteLine(Point3D.PointZero);

            // Problem 03

            double distance = CalculatingDistance.Between(point, Point3D.PointZero);
            Console.WriteLine(distance);  //6.557438524302
            Console.WriteLine();

            Point3D pointOne = new Point3D(1, 1, 1);
            Point3D pointTwo = new Point3D(2, 2, 2);
            Console.WriteLine(CalculatingDistance.Between(pointOne, pointTwo));

            // Promlem 04
            Path sequence = new Path();


            sequence.AddPoint(point);
            sequence.AddPoint(pointOne);
            sequence.AddPoint(pointTwo);

            foreach (var p in sequence.PointSeq)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            Console.WriteLine("Saving...");

            PathStorage.Save(sequence);
            Console.WriteLine();

            Console.WriteLine("Loading...");
            Console.WriteLine();

            PathStorage.Load("path.txt");
            Console.WriteLine();
            
        }
    }
}
