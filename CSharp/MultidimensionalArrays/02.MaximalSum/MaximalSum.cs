/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter height of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
       
        Console.Write("Enter width of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Enter the size of searching square (3 for this task) but could be anything: ");
        int sqrSize = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int localSum = 0;
        int maxSum = int.MinValue;
        
        int printRow = 0;
        int printCol = 0;

        int[,] matrix = new int[n, m];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }

        for (int row = 0; row < matrix.GetLength(0)-(sqrSize-1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-(sqrSize-1); col++)
            {
                for (int sqrRow = row; sqrRow < row+sqrSize; sqrRow++)
                {
                    for (int sqrCol = col; sqrCol < col+sqrSize; sqrCol++)
                    {

                        localSum += matrix[sqrRow, sqrCol];
                        if (localSum > maxSum)
                        {
                            maxSum = localSum;
                            printRow = row;
                            printCol = col;
                        }
                    }
                    
                }

                localSum = 0;
            }
            
           
        }
        Console.WriteLine();

        Console.WriteLine("The maximum found sum is {0}", maxSum);
        Console.WriteLine();

        for (int row = printRow; row < sqrSize+printRow; row++)
        {
            for (int col = printCol; col < sqrSize+printCol; col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
        
       
    }


}

