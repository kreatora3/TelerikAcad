/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/

using System;


class InsideOrOutsideTheCircle
{
    static void Main()
    {
        double xCircle, yCircle, radius;
        xCircle = 0;
        yCircle = 5;
        radius = 5;
        Console.Write("Enter the x coordinate: ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("Enter the y coordinate: ");
        double yPoint = double.Parse(Console.ReadLine());

        double d = Math.Pow((xPoint - xCircle),2) + Math.Pow((yPoint - yCircle),2);

        if (d <= Math.Pow(radius, 2))
        {
            Console.WriteLine("The point with the coordinates x = {0} and y = {1} is inside the circle", xPoint, yPoint);
        }
        else
        {
            Console.WriteLine("The point with the coordinates x = {0} and y = {1} is outside the circle", xPoint, yPoint);
        }
       
    }
}

