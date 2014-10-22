/*You are given an array of strings. Write a method that sorts the array by the length of its elements
 * (the number of characters composing them).*/

using System;
using System.Collections.Generic;

class ArrayOfStringsSort
{
    static void StringSort(string[] array) 
    {
        Array.Sort(array, (y, x) => (y.Length).CompareTo(x.Length));
    
    }

    

    static void Main()
    {
        string[] array = { "dada", "grehsgbv", "asd",  "dastqygDDAka",  "asc", "ab", "a", "ac"};

        StringSort(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);

        }
        Console.WriteLine();
    }
}

