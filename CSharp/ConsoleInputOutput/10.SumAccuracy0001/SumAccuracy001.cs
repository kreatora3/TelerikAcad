/*Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...*/


using System;


class SumAccuracy001
{
    static void Main()
    {
                
        double sumPositive = 1;  //starting sum of positive numbers
        double sumNegative = 0;  // starting sum of negative numbers

        
        for (double dividerP = 2; 1/dividerP > 0.001; dividerP += 2) /* in this for loop we calculate all positive frac numbers until we get 1/1000 which is 0.001. 
                                                                      After that we dont need to calculate as we need only.001 accuracy*/ 
        {
            double fracNumberP = 1 / dividerP;
            sumPositive = sumPositive + fracNumberP;

        }


        for (double dividerN = 3; 1/dividerN > 0.001; dividerN += 2) /*Here we calculate all negative frac numbers until we reach the accuracy we want*/
        {
            double fracNumberN = -(1 / dividerN);
            sumNegative = sumNegative + fracNumberN;
        }
        
        double sum = sumPositive + sumNegative;  // The sum between positive and negative gives us the real sum and after that we print the result.
        
        Console.WriteLine("The sum is {0:0.000}", sum);

        /*The task could be solved with just one for loop if we declare "sign" variable 
         * and every time loops goes through it multiplying the divider by (-1) so even dividers will go "+" and odd divider will go "-"*/
        
    }
    
}

