using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class WordReverse
{
    static void Main()
    {
        Console.Title = "W O R D  Reverser";
        while (true)
        {
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            char[] array = input.ToCharArray();
            Array.Reverse(array);

            string result = new string(array);

            Console.WriteLine("This is the reversed of your input --> {0}", result);
            Console.WriteLine();
        }
            
    }
}

