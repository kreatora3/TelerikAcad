/*Write an expression that checks if given integer is odd or even.*/

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        int nNumber = int.Parse(Console.ReadLine());

        if (nNumber % 2 == 0)
        {
            Console.WriteLine("The entered number is even");
        }
        else
        {
            Console.WriteLine("The entered number is odd");
        }
    }
}

