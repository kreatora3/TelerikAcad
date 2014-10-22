/*Write a program that encodes and decodes a string using given encryption key (cipher). 
 The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
 operation over the first letter of the string with the first of the key, the second – with the second, etc.
 When the last key character is reached, the next is the first.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class EncodeDecode
{
    private static string Decoder(string encoded, string key)
    {
        StringBuilder decodedString = new StringBuilder();

        for (int i = 0; i < encoded.Length; i++)
        {
            decodedString.Append((char)((char)encoded[i] ^ (char)key[i % key.Length]));
        }

        return decodedString.ToString();
    }

    private static string Encode(string toEncode, string key)
    {
        StringBuilder encoded = new StringBuilder();



        for (int i = 0; i < toEncode.Length; i++)
        {
            encoded.Append((char)((char)toEncode[i] ^(char)key[i % key.Length]));
        }


        return encoded.ToString();

    }
   
    static void Main()
    {
        Console.Write("Enter string to encode: ");
        string toEncode = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter encoding key: ");
        string key = Console.ReadLine();
        Console.WriteLine();

        string encoded = Encode(toEncode, key);

        Console.WriteLine("Encoded string is {0}", encoded);
        Console.WriteLine();

       string stringBack =  Decoder(encoded, key);
       Console.WriteLine("Afert decoding  we have our input back --> {0}", stringBack);
       

    }

   
}

