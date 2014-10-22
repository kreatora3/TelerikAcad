/*Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.*/

using System;


class PlusMinusPrograme
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());

        if (a<0 || b<0 || c<0)
        {
            Console.WriteLine("The product of entered numbers is (-) negative ");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The product of entered numbers is (+) positive");
            Console.WriteLine();
        }
    }
}

