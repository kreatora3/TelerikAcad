/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
 * Example: v=5; p=1  false.
*/

using System;


class BooleanExpressionBitOne
{
    static void Main()
    {
        int p;  //position of bit 
        int v; // number

        Console.Write("Enter number: ");
        v = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the bit: ");
        p = int.Parse(Console.ReadLine());

        if (p > 32) 
        {
            Console.WriteLine("Please enter number from 0 to 31 inclusive");
            Console.WriteLine();
            Console.Write("Enter position of the bit: ");
            p = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
       
        int mask = 1 << p;
        int vAndMask = v & mask;
        int result = vAndMask >> p;

        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        Console.WriteLine();
       
        
    }
}

