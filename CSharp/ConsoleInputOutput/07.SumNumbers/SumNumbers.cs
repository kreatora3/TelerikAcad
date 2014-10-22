/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

using System;



class SumNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("As you entered {0}, please now enter {0} numbers one by one and I'll calculate their sum for you :)", n);
        Console.WriteLine();
        int sum = 0;

        for (int counter = 0; counter < n; counter++)
        {
            Console.Write("Enter number: ");
            int numberX = int.Parse(Console.ReadLine());
            sum = sum + numberX;
            Console.WriteLine();
            
        }
        Console.WriteLine("Total is {0}", sum);
        Console.WriteLine();
        
    }
}

