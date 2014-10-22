using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


class KaspichanNumbers
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int toBase = 256;
        BigInteger numberOutput = 0;

        List<string> digits = new List<string>();
        string result = string.Empty;

        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add((i.ToString() + j.ToString()));
            }
        }

        if (number == 0)
        {
            Console.WriteLine('A');
        }

        while (number != 0)
        {
            BigInteger remainder = number % toBase;


            result = digits[(int)remainder] + result;

            number /= toBase;
        }

        Console.WriteLine(result);
    }
}


