/*Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.*/

using System;


class ValueOfBitNumberB
{
    static void Main()
    {

        int i; //integer
        int b; //bit number
        Console.Write("Enter number: ");
        i = int.Parse(Console.ReadLine());
        Console.Write("Enter bit number: ");
        b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int iAndMask = i & mask;
        int value = iAndMask >> b;
        Console.WriteLine();
        Console.WriteLine("The value of bit at position {0} is {1}", b, value);
        Console.WriteLine();
    }
}

