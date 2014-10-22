/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;


    class TrapezoidArea
    {
        static void Main()
        {
            int a, b, h;
            Console.Write("Enter the value of bottom base: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of upper base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of height: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the trapezoid with the given dimensions is {0}", ((a+b)*h)/2);
        }
    }
