using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
   static BigInteger Power (int numeralBase, int length)
   {
       BigInteger product = 1;
       
       for (int i = 0; i < length; i++)
       {
           product *= numeralBase;
       
       }
       return product;
   }
    
    static void Main()
    {
        string[] gagNum = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-"};

        string input = Console.ReadLine();

        

        List<int> extractedNums = new List<int>();
        BigInteger result = 0;
        
        int numeralBase = 9;
        /*  0	-!
            1	**
            2	!!!
            3	&&
            4	&-
            5	!-
            6	*!!!
            7	&*!
            8	!!**!-
        */
        for (int i = 0; i < input.Length;)
        {
            if (input[i] == '-')
            {
                extractedNums.Add(0);
                i += 2;
                continue;
            }
            if (input[i] == '*')
            {
                if (input[i+1] == '*')
                {
                    extractedNums.Add(1);
                    i += 2;
                    continue;
                }
                if (input[i+1] == '!')
                {
                   extractedNums.Add(6);
                   i += 4;
                   continue;
                }
            }
            if (input[i] == '!')
            {
                if (input[i + 1] == '-')
                {
                    extractedNums.Add(5);
                    i += 2;
                    continue;
                }
                if (input[i+2] == '!')
                {
                    extractedNums.Add(2);
                    i += 3;
                    continue;
                }
                if (input[i+2] == '*')
                {
                    extractedNums.Add(8);
                    i += 6;
                    continue;
                }
            }
            if (input[i] == '&')
            {
                if (input[i+1] == '&')
                {
                    extractedNums.Add(3);
                    i += 2;
                    continue;
                }
                if (input[i + 1] == '-')
                {
                    extractedNums.Add(4);
                    i += 2;
                    continue;
                }
                if (input[i + 1] == '*')
                {
                    extractedNums.Add(7);
                    i += 3;
                    continue;
                }
            }
        }
        //extractedNums.Reverse();

        for (int i = 0; i < extractedNums.Count; i++)
        {

           // result += extractedNums[i] * Power(numeralBase, extractedNums.Count - i - 1);
            result *= numeralBase;
            result += extractedNums[i];
            
        }
      
        Console.WriteLine(result);
    }
}

