/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class  RandomValues

{
    static void Main()
    {
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(100, 200));
        }
        Console.WriteLine();
    }
}

