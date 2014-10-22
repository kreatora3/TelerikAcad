/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.*/

using System;

class ThirdBitOneOrZero
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int numberEight = 8;

        
        int result = number & numberEight;
        
        if (result == 0) 
        { 
            Console.WriteLine("The  bit at position 3 counting from zero is  0");
        }
        else
        {
            Console.WriteLine("The  bit at position 3 counting from zero is 1");
        }
        Console.WriteLine();
    }
}


