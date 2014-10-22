/*Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.*/

using System;


class NameOfDigit
{
    static void Main()
    {
        Console.Write("Enter digit: ");
      
        int digit = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (digit)
        {
            case 1: Console.WriteLine("Hey, you entered One"); break;
            case 2: Console.WriteLine("Hey, you entered Two"); break;
            case 3: Console.WriteLine("Hey, you entered Three"); break;
            case 4: Console.WriteLine("Hey, you entered Four"); break;
            case 5: Console.WriteLine("Hey, you entered Five"); break;
            case 6: Console.WriteLine("Hey, you entered Six"); break;
            case 7: Console.WriteLine("Hey, you entered Seven"); break;
            case 8: Console.WriteLine("Hey, you entered Eight"); break;
            case 9: Console.WriteLine("Hey, you entered Nine"); break;
            case 0: Console.WriteLine("Hey, you entered Zero"); break;
            default: Console.WriteLine("Next time enter digit between (0-9)"); break;
        }
        Console.WriteLine();
    }
}
