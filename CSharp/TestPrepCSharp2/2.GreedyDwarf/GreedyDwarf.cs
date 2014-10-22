using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


class GreedyDwarf
{
    static void Main()
    {
        char[] separator = { ',', ' '};

        string input = Console.ReadLine();

        string[] field = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        bool[] isVisited = new bool[field.Length];
        List<long> maxSum = new List<long>();

        
        long currentCollected = 0;
        int position = 0;
        int lineCounter = 0;

        int m = int.Parse(Console.ReadLine());

               

        for (int i = 0; i < m; i++)
        {
            string[] line = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            
            while (true)
            {    
                if (position < field.Length && position >= 0)
                {
                    if (isVisited[position] == true)
                    {
                        isVisited = new bool[field.Length];
                        position = 0;
                        maxSum.Add(currentCollected);
                        currentCollected = 0;
                        lineCounter = 0;
                        break;
                    }
                    else
                    {
                        currentCollected += long.Parse(field[position]);
                        isVisited[position] = true;
                        position += int.Parse(line[lineCounter]);
                        lineCounter++;
                                                
                        if (lineCounter >= line.Length)
                        {
                            lineCounter = 0;
                        }
                    }
                }
                else
                {
                    isVisited = new bool[field.Length];
                    position = 0;
                    maxSum.Add(currentCollected);
                    currentCollected = 0;
                    lineCounter = 0;
                    break;
                }
            }
        }

        maxSum.Sort();
        Console.WriteLine(maxSum.Max());
        
    }
}

