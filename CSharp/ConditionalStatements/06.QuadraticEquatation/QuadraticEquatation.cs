/*Write a program that enters the coefficients a, b and c of a quadratic equation
a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/

using System;

class QuadraticEquatation
{
    static void Main()
    {
        Console.Write("Enter parameter \'a\': ");
        double a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter parameter \'b\': ");
        double b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter parameter \'c\': ");
        double c = int.Parse(Console.ReadLine());
        Console.WriteLine();

        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots for this quadratic equatation");
        }
        else if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("Quadratic equatation has two roots: \nx1 = {0:0.00}\nx2={1:0.00}", x1, x2);
        }
        else
        {
            double x = -(b / 2 * a);
            Console.WriteLine("Quadratic equatation has exactly one root and it value is {0:0.00}", x);

        }
    }
}

