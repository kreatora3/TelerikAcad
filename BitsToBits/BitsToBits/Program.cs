namespace BitsToBits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Program
    {
        public static void Main(string[] args)
        {
            var numberOflines = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < numberOflines; i++)
            {
                var number = int.Parse(Console.ReadLine());
                var binaryNumber = Convert.ToString(number, 2);

                if (binaryNumber.Length < 30)
                {
                    sb.Append(binaryNumber.PadLeft(30, '0'));
                }
                else
                {
                    sb.Append(binaryNumber.Substring(binaryNumber.Length - 30, 30));
                }
            }

            var maxZeroes = 0;
            var maxOnes = 0;

            var currentZeroes = 0;
            var currentOnes = 0;
            var concatenatedString = sb.ToString();

            for (int i = 0; i < concatenatedString.Length; i++)
            {
                if (concatenatedString[i] == '0')
                {
                    currentOnes = 0;
                    currentZeroes += 1;
                    if (maxZeroes < currentZeroes)
                    {
                        maxZeroes = currentZeroes;
                    }
                }
                else
                {
                    currentZeroes = 0;
                    currentOnes += 1;
                    if (maxOnes < currentOnes)
                    {
                        maxOnes = currentOnes;
                    }
                }
            }

            Console.WriteLine(maxZeroes);
            Console.WriteLine(maxOnes);
        }
    }
}
