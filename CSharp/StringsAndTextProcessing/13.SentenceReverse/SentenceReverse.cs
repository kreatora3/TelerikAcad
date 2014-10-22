/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SentenceReverse
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine("The text to be reversed --> {0}", str);
        Console.WriteLine();
        int commaCounter= 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                commaCounter++;
            }
            if (str[i] == ',' && str[i+1] == ' ')     /* If we have other text with more commas or other punctual signs we can
                                                       create List<> to count after which whitespace to put them*/
            {
                commaCounter++;
                break;
            }
        }

        string[] spl = str.Split(new char[]{',','!'});
        StringBuilder sb = new StringBuilder();

        for (int i = spl.Length-1; i >= 0; i--)
        {
            string[] words = spl[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            for (int j = 0; j < words.Length; j++)
            {
                sb.Append(words[j]);                
                commaCounter--;
                if (commaCounter == 0)
                {
                    sb.Append(",");
                }
                sb.Append(" ");
            }
            
        }
        string result = sb.ToString().Trim() + "!";/*Depending on size of text we can create list to put the position of !,.,: and other sign.
                                                     For the purposes of this homework we just append ! to the end*/
                
        Console.WriteLine(result);
        Console.WriteLine();
    }
}

