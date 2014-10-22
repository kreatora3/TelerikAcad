namespace Shape
{
    using System;
    using System.Collections.Generic;
    
   public class ShapeSurfTest
    {
       public static void Main()
        {
            Shape[] mixedShapes = new Shape[] 
            {
                 new Rectangle(3, 4),
                 new Triangle(3, 4),
                 new Circle(3)
            };

            foreach (var fig in mixedShapes)
            {
                Console.WriteLine(fig.CalculateSurface());
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
