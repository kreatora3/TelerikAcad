using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ConsoleJustification
{
    static void Main()
    {
        //Console.SetIn(new System.IO.StreamReader("test.002.in.txt"));
       // string whiteSpace = " ";
        int wordCounter =0;
        StringBuilder sentence = new StringBuilder();
        int numberOfLines = int.Parse(Console.ReadLine());
        int lineLenght = int.Parse(Console.ReadLine());
        List<string> allWords = new List<string>();
        List<string> result = new List<string>();
       

        for (int i = 0; i < numberOfLines; i++)
        {
            string line = Console.ReadLine();
            string[] words = line.Split(new char[]{' ','\n'}, StringSplitOptions.RemoveEmptyEntries);
                      
                for (int j = 0; j < words.Length; j++)
                {
                    allWords.Add(words[j]);
                }
            
        }
        

        for (int i = 0; i < allWords.Count; i++)
        {
            
            sentence.Append(allWords[i]);

            sentence.Append(" ");

            if (sentence.Length < lineLenght)
            {
                wordCounter++;
                continue;
            }
            if (sentence.Length == lineLenght + 1)
            {
                
                result.Add(sentence.ToString().Trim());
                wordCounter = 0;
                sentence = new StringBuilder();
                continue;
            }
            if (sentence.Length > lineLenght)
            {
                sentence.Remove((sentence.Length-1 - allWords[i].Length), allWords[i].Length);
                i--;
               
                if (wordCounter == 1)
                {
                    result.Add(sentence.ToString().Trim());
                    wordCounter = 0;
                    sentence = new StringBuilder();
                    continue;
                }
                else
                {                                      
                  
                    result.Add(sentence.ToString().Trim());
                    wordCounter = 0;
                    sentence = new StringBuilder();
                    continue;
                    
                }
                
            }
           
        }
        result.Add(sentence.ToString().Trim());

        int indxOf = 0;        
        int nextIndex = 0;
        List<int> index = new List<int>();
        

        for (int i = 0; i < result.Count; i++)
        {
            
            if (result[i].Length < lineLenght)
            {
                indxOf = result[i].IndexOf(" ", nextIndex);
                
                if (indxOf == -1 )
                {
                    continue;
                }
                
                int start = 0;
                
                while (result[i].Length != lineLenght)
                {                   

                    if (result[i][start] == ' ' && result[i][start +1] != ' ')
                    {
                        result[i] = result[i].Insert(start, " ");
                        start++;
                    }
                    start++;
                    if (start >= result[i].Length)
                    {
                        start = 0;
                    }
                }
               
                
               
                //while (result[i].Length != lineLenght)
                //{
                //    result[i] = result[i].Insert(indxOf + 1, " ");
                //    indxOf = result[i].IndexOf(" ", indxOf + whiteSpaceCounter);
                //   if (indxOf == -1)
                //   {
                //       whiteSpaceCounter+=2;
                //       indxOf = result[i].IndexOf(" ");
                //   }
                //}
                //whiteSpaceCounter = 2;
            }
        }

        

        foreach (var item in result)
        {
            Console.WriteLine(item.Trim());
        }        
    }
}

