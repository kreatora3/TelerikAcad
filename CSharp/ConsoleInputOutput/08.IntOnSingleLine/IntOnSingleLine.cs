/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

class IntOnSingleLine
{
    static void Main()
    {
        Console.Write("Enter number for the end of the counter: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine(i+1);
        }
        Console.WriteLine();
    }
}

