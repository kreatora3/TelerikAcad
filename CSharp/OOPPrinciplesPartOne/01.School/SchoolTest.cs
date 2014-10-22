namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class SchoolTest
    {
        public static void Main()
        {
            Teachers t = new Teachers("Ivanov", new List<Disciplines>() 
            {
                             new Disciplines("Math", 10, 10),
                             new Disciplines("English", 15, 15)
            });

            Console.WriteLine(t);
            Console.WriteLine();

            Klas aKlas = new Klas("A", new List<Teachers>() { t });

            Console.WriteLine(aKlas);
            Console.WriteLine();

            Students pesho = new Students("Pesho", 219299);
            Console.WriteLine(pesho);
            Console.WriteLine();
        }
    }
}
