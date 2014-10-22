/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.*/


using System;


class SubsetSum
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int counter = 0;
        
        int[] numArray = new int[n];

        for (int i = 0; i < numArray.Length; i++)
        {
            Console.Write("Enter number {0} --> ", i+1);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        for (int maxCombination = 1; maxCombination < Math.Pow(2, (numArray.Length)); maxCombination++)
        {
            int sum = 0;
            for (int eachMember = 0; eachMember < numArray.Length; eachMember++)
            {
                sum += ((maxCombination >> eachMember) & 1) * numArray[eachMember];
                
            }
            if (sum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("There are exactly {0} subsets which sum is zero", counter);
        Console.WriteLine();
    }
}

