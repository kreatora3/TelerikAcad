/*We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)*/

using System;


class ValueVZeroOrOne
{
    static void Main()
    {
        int n; //number
        int p; // bit position
        int v; // 0 or 1 

        Console.Write("Enter number: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the bit you want to change with 1 or 0: ");
        p = int.Parse(Console.ReadLine());
        Console.Write("Enter 0 or 1: ");
        v = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (v == 0)
        {
            int maskZero = ~(1 << p);
            int resultZero = n & maskZero;
            Console.WriteLine(resultZero);
            Console.WriteLine();
        }

        if (v == 1)
        {
            int maskOne = 1 << p;
            int resultOne = n | maskOne;
            Console.WriteLine(resultOne);
            Console.WriteLine();
        }
    }
}

