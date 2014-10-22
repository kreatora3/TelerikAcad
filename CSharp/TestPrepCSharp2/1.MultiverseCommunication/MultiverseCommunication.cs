using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MultiverseCommunication
{
    static void Main()
    {
        string[] numeralSys = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        int numeralBase = 13;

        string message = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        ulong result = 0;

        

        for (int i = 0; i < message.Length; i+=3)
        {
            for (int j = i; j < i+3; j++)
            {
                sb.Append(message[j]);                            
                
            }

            for (int z = 0; z < numeralSys.Length; z++)
            {
                if (sb.ToString() == numeralSys[z])
                {
                    result *= (ulong)numeralBase;
                    result += (ulong)z;
                }
            }
            sb.Clear();
        }
        Console.WriteLine(result);
    }
}

