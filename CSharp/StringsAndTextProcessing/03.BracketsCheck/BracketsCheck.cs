/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BracketsCheck
{
    static void CheckBrackets(string expression) 
    {
        int countOpen = 0;
        int countClose = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countOpen++;
            }
            if (expression[i] == ')')
            {
                countClose++;
            }
        }

        if (countOpen == countClose)
        {
            Console.WriteLine("Correct expression");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong!!!");
            Console.WriteLine();
        }
    
    }
    
    static void Main()
    {
        string expression = "((a+b)/5-d)";
        string expression2 = " )(a+b))";

        CheckBrackets(expression);
        CheckBrackets(expression2);

    }
}

