/*Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 54, 64, 4, 121, 431, 5, 555, 9 }; //if you want put other numbers :)

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Array.Sort(array);

        foreach (var item in array)
        {
            Console.Write("{0}, ", item);
        }
        Console.WriteLine();

      int result =  Array.BinarySearch(array, k);
      Console.WriteLine();

      if (result > 0)  //finds if there is number equal to K 
      {
          Console.WriteLine("The number k ({0}) is equal to number at index {1} which is {2}", k, result, array[result]);
      }
        if (result == -1) //finds that K is the lesser number in the array
      {
          Console.WriteLine("No such number that is lesser or equal to {0}", k);
      }
     
        if (~result > -1 ) //finds the biggest number that is at least equal or lesser than K 
      {
          
          Console.WriteLine("The bigges number that is lesser or equal to {0} is {1}",  k, array[~result-1]);
      }
        Console.WriteLine();     
        
    }
}

