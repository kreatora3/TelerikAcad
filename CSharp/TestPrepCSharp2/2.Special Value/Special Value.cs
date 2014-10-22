

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        int rowNum = int.Parse(Console.ReadLine());

        int[][]  jagged = new int[rowNum][];
        bool[][] used = new bool[rowNum][];
        char[] separator = { ',', ' ' };

        int currentMax = 0;
        int maxValue = int.MinValue;
        int path = 1;               
      

        for (int i = 0; i < rowNum; i++)
        {
            //Console.WriteLine("Enter");
            string col = Console.ReadLine();
            string[] column = col.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            jagged[i] = new int[column.Length];
            used[i] = new bool[column.Length];

            for (int j = 0; j < column.Length; j++)
            {
                jagged[i][j] = int.Parse(column[j]);
            }

        }
        #region maxFind
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 0; i < jagged[0].Length; i++)
        {
            currentCol = i;
            currentRow = 0;
            while (true)
            {                

                if (jagged[currentRow][currentCol] < 0)
                {
                    currentMax = path + Math.Abs(jagged[currentRow][currentCol]);
                    if (currentMax > maxValue)
                    {
                        maxValue = currentMax;
                        currentMax = 0;
                    }
                    
                    break;

                }
                if (used[currentRow][currentCol] == true)
                {
                    for (int j = 0; j < rowNum; j++)
                    {
                        used[j] = new bool[jagged[j].Length];
                    }
                    break;
                }
                if (jagged[currentRow][currentCol] >= 0)
                {
                    used[currentRow][currentCol] = true;
                    currentCol = jagged[currentRow][currentCol];
                    path++;
                    currentRow++;
                    if (currentRow >= rowNum)
                    {
                        currentRow = 0;
                    }
                }
            }

            path = 1;
        }
         
               
        
        Console.WriteLine(maxValue);
        #endregion

        //for (int i = 0; i < jagged.Length; i++)
        //{
        //    int[] inner = jagged[i];
        //    for (int j = 0; j < inner.Length; j++)
        //    {
        //        Console.WriteLine(jagged[i][j]);
        //    }
        //}
    }
}

