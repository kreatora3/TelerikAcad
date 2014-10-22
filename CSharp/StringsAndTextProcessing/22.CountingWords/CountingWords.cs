/*Write a program that reads a string from the console and lists all different words 
 in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CountingWords
{
    static void Main()
    {
        string text = @"RemoveAll filters and removes elements. It can be used with a lambda expression. 
                        This reduces the size of your code and improves its clarity. The List RemoveAll method accepts a
                        Predicate expression for this purpose.PredicateExample First, this example removes all elements 
                        with values of 2. The lambda expression, with the => syntax, matches elements with value of 2.
                        You could use another expression, such as item => item != 2, to remove elements not equal to 2.";

        
        string[] words = text.Split(new char[] { ' ', ',', '.','\n','\t', '\r','!','=','>' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> result = new Dictionary<string, int>();

        
        foreach (var item in words)
        {
            if (result.ContainsKey(item))
            {
                result[item]= result[item] + 1;
            }
            else
            {
                result.Add(item, 1);
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine("Word <{0}> is found {1} times", item.Key, item.Value);
        }
    }
}

