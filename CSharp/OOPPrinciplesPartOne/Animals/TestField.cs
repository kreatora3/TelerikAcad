namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestField
    {
        public static void Main()
        {
            Frog[] swamp = 
            { 
                      new Frog("frog1", 3, true),
                      new Frog("frog2", 4, false),
                      new Frog("frog3", 3, true)
            };

            Console.WriteLine("Here come the frogs...");
         
            foreach (var item in swamp)
            {
                item.MakeSomeNoise();
            }

            Console.WriteLine();

            Console.WriteLine("Average age of our frogs is {0}", Animal.AverageAge(swamp));

            Console.WriteLine();

            Dog[] dogYard = { 
                             new Dog("Sharo", 7, true), 
                             new Dog("Pes", 8, true),
                             new Dog("Roshko", 5, true)
                            };

            Console.WriteLine("Here come the dogs...");

            foreach (var item in dogYard)
            {
                item.MakeSomeNoise();
            }

            Console.WriteLine();

            Console.WriteLine("Average age of our dogs is {0}", Animal.AverageAge(dogYard));

            Console.WriteLine();

            Tomcat[] catKingdom = {
                                  new Tomcat("Tom", 5),
                                  new Tomcat("Garfield", 3),
                                  new Tomcat("Jinks", 5)
                                 };

            Console.WriteLine("Here come the Tomcats...");

            foreach (var item in catKingdom)
            {
                item.MakeSomeNoise();
            }

            Console.WriteLine();

            Console.WriteLine("Average age of our tomcats is {0}", Animal.AverageAge(catKingdom));

            Console.WriteLine();

            Kitten[] cats = {
                              new Kitten("Mini", 8),
                              new Kitten("Maini", 2),
                              new Kitten("Mo", 1)
                            };

            Console.WriteLine("Here come the Kittens...");

            foreach (var item in cats)
            {
                item.MakeSomeNoise();
            }

            Console.WriteLine();

            Console.WriteLine("Average age of our tomcats is {0}", Animal.AverageAge(cats));

            Console.WriteLine();
        }
    }
}
