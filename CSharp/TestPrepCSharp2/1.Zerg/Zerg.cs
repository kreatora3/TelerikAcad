using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Zerg
{
    static void Main()
    {
        string[] zergNum = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", 
                               "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        string message = Console.ReadLine();
        ulong result = 0;
        ulong numeralBase = 15;

        for (int i = 0; i < message.Length; i+=4)
        {
            string digit = message.Substring(i, 4);

            for (int j = 0; j < zergNum.Length; j++)
            {
                if (zergNum[j] == digit)
                {
                    result *= numeralBase;
                    result += (ulong)j;
                }
            }
        }

        Console.WriteLine(result);
    }
}

