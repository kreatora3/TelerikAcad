namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestStudent
    {
        public static void Main()
        {
            // Problem 1
            Console.WriteLine("Problem 1...");
            Console.WriteLine();

            Student st1 = new Student();
            Student st2 = new Student();

            st1.Ssn = 12231;
            st1.FirstName = "Pesho";
            st1.MidName = "Georgiev";
            st1.LastName = "Dimitrov";
            st1.Uni = University.SofiaUni;
            st1.Faculty = Faculty.Math;
            st1.Spec = Specialty.Math;
            st1.Course = 1;

            st2.Ssn = 23339;
            st2.FirstName = "Tosho";
            st2.MidName = "Dimitrov";
            st2.LastName = "Petrov";
            st2.Uni = University.SofiaUni;
            st2.Faculty = Faculty.Math;
            st2.Spec = Specialty.Math;
            st2.Course = 1;

            Console.WriteLine(Equals(st1, st2));
            Console.WriteLine(st1);
            Console.WriteLine();

            // Problem 2 
            Console.WriteLine("Problem 2 ....");
            Console.WriteLine();

            Student st3 = (Student)st1.Clone();
            st3.FirstName = "Ivan";   // Changing name does not affect st1's name hence we have real deep clone.
            Console.WriteLine(st1.FirstName);
            Console.WriteLine(st3.FirstName);
            Console.WriteLine();

            // Problem 3
            Console.WriteLine("Problem 3....");
            Console.WriteLine();

            st3.Ssn = 12232;   // The only difference with st1 is SSN 
            st3.FirstName = "Pesho";
            st3.MidName = "Georgiev";
            st3.LastName = "Dimitrov";
            st3.Uni = University.SofiaUni;
            st3.Faculty = Faculty.Math;
            st3.Spec = Specialty.Math;
            st3.Course = 1;

            List<Student> list = new List<Student>();

            list.Add(st1);
            list.Add(st2);
            list.Add(st3);

            var sorted = list.OrderBy(st => st.FirstName)
                .ThenBy(st => st.MidName)
                .ThenBy(st => st.LastName)
                .ThenBy(st => st.Ssn).ToList();

            foreach (var st in sorted)
            {
                Console.WriteLine(st);
            }
        }
    }
}
