using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericClass
{
    class GenericTest
    {
        static void Main()
        {
            
            GenericList<int> test = new GenericList<int>(25);
            GenericList<string> newTest = new GenericList<string>();

            for (int i = 0; i < 10; i++)
            {
                test.AddElements(i*2);
            }

            for (int i = 0; i < 9; i++)
            {
               newTest.AddElements(((char)(65+i)).ToString());
            }

            test.AddElements(1223939);
            newTest.AddElements("New added element");

            Console.WriteLine(test);
            Console.WriteLine(newTest);

            Console.WriteLine(test[2]);
            Console.WriteLine();
            Console.WriteLine(newTest[3]);
           
            Console.WriteLine();
            test.Clear();
            Console.WriteLine(test);
           
            Console.WriteLine();
            newTest.FindElement("A");
            newTest.InsertAtIndex("Inserted", 3);
            Console.WriteLine();
            Console.WriteLine(newTest);

            Console.WriteLine();
            newTest.RemoveAtIndex(9);
            Console.WriteLine(newTest);
            Console.WriteLine();

            for (int i = 0 ; i < 10; i++)
            {
                test.AddElements(i * 3);
            }

            Console.WriteLine(test.Max());
            Console.WriteLine();
            Console.WriteLine(test.Min());
            Console.WriteLine();

           
        }
    }
}
