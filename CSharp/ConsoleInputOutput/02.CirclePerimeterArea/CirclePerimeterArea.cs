/*Write a program that reads the radius r of a circle and prints its perimeter and area.*/

using System;


class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter the radius of a circle: ");
        int radius = int.Parse(Console.ReadLine());
        double pi = Math.PI;
        double circleArea = pi * radius * radius;
        double circlePerimeter = 2 * pi * radius;

        Console.WriteLine("The area of the circle with radius {0} is {1}", radius, circleArea);
        Console.WriteLine("The perimeter of the circle with raduis {0} is {1}", radius, circlePerimeter);
    }
}

