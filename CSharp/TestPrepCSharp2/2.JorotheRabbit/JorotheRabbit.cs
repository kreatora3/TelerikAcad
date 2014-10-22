using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class JorotheRabbit
{
    static void Main()
    {
        string str = Console.ReadLine();

        string[] field = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
       
        int counter = 1;
        int currentPosition = 0;
        int maxCounter = 0;
        
              
        int[] numbers = new int[field.Length];
        for (int i = 0; i < field.Length; i++)
        {
            numbers[i] = int.Parse(field[i]);
        }


        for (int step = 1; step <=  numbers.Length; step++)
        {
            for (int starting = 0; starting < numbers.Length; starting++)
            {
                currentPosition = starting;
                while (true)
                {                   
                   
                    if (numbers[currentPosition] < numbers[(currentPosition + step) % numbers.Length])
                    {     
                            counter++;
                            currentPosition = currentPosition+step;
                            
                        if (currentPosition >= numbers.Length)
                            {
                                currentPosition = currentPosition % numbers.Length;
                            }
                    }

                    else
                    {
                        break;
                    }

                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                }
                counter = 1;
            }
            
              
            
        }

        Console.WriteLine(maxCounter);
    }
}

