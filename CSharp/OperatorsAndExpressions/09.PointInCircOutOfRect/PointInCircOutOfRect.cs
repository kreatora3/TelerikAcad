/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
 * and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
using System;


class PointInCircOutOfRect
{
    static void Main()
    {
        //cirlce 
        double xCircle, yCircle, radius;
        xCircle = 1;
        yCircle = 1;
        radius = 3;
        //rectangle
        double xTopCoordinate, yLeftCoordinate, width, height;
        xTopCoordinate = 1;
        yLeftCoordinate = -1;
        width = 6;
        height = 2;
        Console.Write("Enter the x coordinate: ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("Enter the y coordinate: ");
        double yPoint = double.Parse(Console.ReadLine());
        Console.WriteLine();

        double d = Math.Pow((xPoint - xCircle), 2) + Math.Pow((yPoint - yCircle), 2);


        if (d <= Math.Pow(radius, 2))
        {
            Console.Write("The point with the given coordinates is in the circle" ); 
        }
        else
        {
            Console.Write("The point with the given coordinates is outside the circle");
        }
        
        Console.Write(" and ");

       
        if (((xTopCoordinate) >= xPoint) || (xPoint >= (xTopCoordinate + width)) || (yLeftCoordinate <= yPoint) || (yPoint <=((yLeftCoordinate - height))))
        {
            Console.WriteLine("the point is \noutside the rectangle");

        }
        else
        {
            Console.WriteLine("the point is \ninside the rectangle");
        }
        Console.WriteLine();
    }

}

