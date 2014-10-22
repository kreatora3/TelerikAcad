/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class TriangleSurface
{
    private static double SideAndAltitude(double a, double h)
    {
        double area = (a * h) / 2;
        return area;
    }
    
    private static double HeronsFormula(double a, double b, double c)
    {
        double p = (a + b + c)/2;
        double area = (double)(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        return area;
    }

    private static double SideAngeSide(double b, double c, double angle)
    {
        double convertToDegrees = (Math.PI * angle) / 180;
        double area = ((b * c) / 2) * Math.Sin(convertToDegrees);
        return area;
    }

    static void Main()
    {
        double sideA = 5;
        double heightA = 3;
        Console.WriteLine(SideAndAltitude(sideA, heightA));
        Console.WriteLine();

        double a = 3;
        double b = 4;
        double c = 5;        
        Console.WriteLine(HeronsFormula(a, b, c));
        Console.WriteLine();

        double sideB = 231;
        double siceC = 150;
        double angle = 123;

        Console.WriteLine(SideAngeSide(siceC, sideB, angle));
        Console.WriteLine();
    }

   
    

   
}

