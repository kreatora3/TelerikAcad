using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DurankulakNumbers
{
    static void Main()
    {
        

        List<string> numbers = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            numbers.Add(i.ToString());
        }

        for (char  i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                numbers.Add(i.ToString() + j.ToString());
            }
        }

        string inputDnmbr = Console.ReadLine();

        List<int> decRepres = new List<int>();
        int numeralBase = 168;
        ulong result = 0;

       

        for (int i = 0; i < inputDnmbr.Length; i++)
        {
            if (inputDnmbr[i] < 'a')
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (inputDnmbr[i].ToString() == numbers[j])
                    {
                        decRepres.Add(j);
                    }
                }
            }
            if (inputDnmbr[i] >= 'a')
            {
                for (int k = 0; k < numbers.Count; k++)
                {
                    if ((inputDnmbr[i].ToString() + inputDnmbr[i + 1].ToString()) == numbers[k])
                    {
                        decRepres.Add(k);
                        
                    }
                       
                }
                i++;
            }
        }

        for (int i = 0; i < decRepres.Count; i++)
        {
            result *= (ulong)numeralBase;
            result += (ulong)decRepres[i];
        }
        Console.WriteLine(result);
    }
}

