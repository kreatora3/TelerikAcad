/*Write an expression that calculates rectangle’s area by given width and height.*/

using System;


class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());

        int area = height * width;

        Console.WriteLine();

        Console.WriteLine("The area of the rectangle is {0}", area);
        Console.WriteLine();
    }
}

