/* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. */

using System;



class NumberRead
{
    static void Main()
    {
        string[] zeroToNineteenArr = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", 
                                      "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

        string[] tensArr = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        Console.Write("Enter number between (0-999) and I'll read it for you: ");
        string numberStr = Console.ReadLine();
        Console.WriteLine();
        int digit = int.Parse(numberStr);


        if (numberStr.Length == 1) 
        {
            Console.WriteLine(zeroToNineteenArr[digit]);
        }
        
        if (numberStr.Length == 2)
        {
            int tens = numberStr[0] - '0';
            int ones = numberStr[1] - '0';
           
            if (digit < 20)
            {
                Console.WriteLine(zeroToNineteenArr[digit]);
            }
            else if(ones == 0)
            {
                Console.WriteLine(tensArr[tens-2]);
            }
            else
            {                
                Console.WriteLine(tensArr[tens - 2] + " " + zeroToNineteenArr[ones]);
            }
        }

        if (numberStr.Length == 3)
        {
            int hundreds = numberStr[0] - '0';
            int tens = numberStr[1] - '0';
            int ones = numberStr[2] - '0';

            if (tens == 1)
            {
                if (ones == 0)
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred " + "and " + zeroToNineteenArr[10]);
                }
                else
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred " + "and " + zeroToNineteenArr[10 + ones]);
                }
            }
            if (tens > 1)
            {
                if (ones == 0)
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred " + "and " + tensArr[tens - 2]);
                }
                else
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred " + "and " + tensArr[tens - 2] + " " + zeroToNineteenArr[ones]);
                }
            }
            if (tens == 0)
            {
                if (ones == 0)
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred ");
                }
                else
                {
                    Console.WriteLine(zeroToNineteenArr[hundreds] + " Hundred " + " and " + zeroToNineteenArr[ones]);
                }
            }

        }
        Console.WriteLine();
    }
}


