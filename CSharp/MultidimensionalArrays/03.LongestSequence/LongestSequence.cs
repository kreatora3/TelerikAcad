
/*We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
using System.Collections.Generic;

class LongestSequence
{
    static void Main()
    {
        string[,] testMatrix = {
                                  {"ha", "fifi", "ho", "hi"},
                                  {"fo", "ha", "hi", "xx"},
                                  {"xxx", "ho", "ha", "xx"},
                               };

        
        string mostFrequent = testMatrix[0, 0];
        int bestCount = 1;
        int count = 0;

        for (int row = 0; row < testMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < testMatrix.GetLength(1); col++)
            {
                count = 1;

                
                for (int i = col; i < testMatrix.GetLength(1) - 1; i++)
                {
                    if (testMatrix[row, i] == testMatrix[row, i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    mostFrequent = testMatrix[row, col];
                }
                count = 1;

               
                for (int i = row; i < testMatrix.GetLength(0) - 1; i++)
                {
                    if (testMatrix[i, col] == testMatrix[i + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    mostFrequent = testMatrix[row, col];
                }
                count = 1;

              
                for (int i = row, j = col; i < testMatrix.GetLength(0) - 1 && j < testMatrix.GetLength(1) - 1; i++, j++)
                {
                    if (testMatrix[i, j] == testMatrix[i + 1, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        mostFrequent = testMatrix[row, col];
                    }
                }

               
                for (int i = row, j = col; i < testMatrix.GetLength(0) - 1 && j > 0; i++, j--)
                {
                    if (testMatrix[i, j] == testMatrix[i + 1, j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        mostFrequent = testMatrix[row, col];
                    }
                }

            }
        }
       
        for (int i = 0; i < bestCount - 1; i++)
        {
            Console.Write(mostFrequent + ", ");
        }
        Console.WriteLine(mostFrequent + " --> " + bestCount + " times");
    }
}

