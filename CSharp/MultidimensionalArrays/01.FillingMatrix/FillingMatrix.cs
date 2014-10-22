/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
*/

using System;
using System.Collections.Generic;

class FillingMatrix
{
    
   
    //Printing Method
    static void PrintMatrix(int[,] array, int n) 
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", array[row,col].ToString().PadLeft(2));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        

        int[,] matrix = new int[n, n];

        // variant a);
        int fillerA = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = fillerA;                
                fillerA += n;                
            }
           
            fillerA = row + 2;
        }
        Console.WriteLine("Variant A");
        Console.WriteLine();
        PrintMatrix(matrix, n);
       
        //variant b);

        int fillerB = 1;
        int[,] matrixB = new int[n,n];

        for (int col = 0; col < n; col++)
        {
            for (int row  = 0; row < n; row++)
            {
                if (col % 2 == 0 )
                {
                    matrixB[row, col] = fillerB;
                    fillerB++;
                }
                else
                {                    
                    matrixB[row, col] = fillerB;
                    fillerB--;
                }
                
            }
            if (col % 2 == 0)
            {
                fillerB += n - 1; 
            }
            else
            {
                fillerB += n + 1;
            }
        }
        Console.WriteLine("Variant B");
        Console.WriteLine();
        PrintMatrix(matrixB, n);


        //Variant c);

        int[,] matrixC = new int[n, n];
        int currentRow = matrixC.GetLength(0)-1;
        int currentCol= 1; 
        int fillerDownLeft = 1;
        
        
        while (currentRow >= 0)
        {

            for (int i = currentRow; i < matrixC.GetLength(0); i++)
            {                                
                    matrixC[i, i - currentRow ] = fillerDownLeft;
                    fillerDownLeft++;     
                
            }
            currentRow--;
           
           
        }

        while (currentCol < matrixC.GetLength(1))
        {
            for (int i = currentCol; i < matrixC.GetLength(1); i++)
            {
                matrixC[(i-currentCol), i] = fillerDownLeft;
                fillerDownLeft++;
            }
           currentCol++;
        }
        Console.WriteLine("Variant C");
        Console.WriteLine();
        PrintMatrix(matrixC, n);
    }

}

