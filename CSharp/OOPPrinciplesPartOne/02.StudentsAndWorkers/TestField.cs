namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestField
    {
        public static void Main()
        {
            List<Student> studList = new List<Student>()
            {
                new Student("Angel", "Petrov", 1),
                new Student("Ivan", "Petrov", 2),
                new Student("Niki", "Petrov", 3),
                new Student("Ivo", "Petrov", 4),
                new Student("Petar", "Petrov", 1),
                new Student("Simeon", "Petrov", 2),
                new Student("Kubrat", "Petrov", 3),
                new Student("Tervel", "Petrov", 4),
                new Student("Kiril", "Petrov", 1),
                new Student("Evtim", "Petrov", 2)
            };

            List<Worker> workList = new List<Worker>()
            {
                new Worker("Petar", "Angelov", 250, 8),
                new Worker("Ivan", "Angelov", 350, 8),
                new Worker("Niki", "Angelov", 450, 8),
                new Worker("Ivo", "Angelov", 550, 8),
                new Worker("Stamat", "Angelov", 250, 8),
                new Worker("Simeon ", "Angelov", 350, 8),
                new Worker("Kubrat", "Angelov", 450, 8),
                new Worker("Tervel", "Angelov", 550, 8),
                new Worker("Kiril", "Angelov", 650, 8),
                new Worker("Evtim", "Angelov", 250, 8)
            };

           // Sorting students with LINQ
            var gradeSort =
                from st in studList
                orderby st.Grade ascending
                select st;
            foreach (var item in gradeSort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Sorting workers Lambda expressions
            var orderByMoney = workList.OrderByDescending(wk => wk.MoneyPerHour());

            foreach (var item in orderByMoney)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            // Merge both lists and sorting them ...
            var commonList = studList.Cast<Human>().Concat(workList.Cast<Human>()).ToList();

            var finalOrder = commonList.OrderBy(person => person.FirstName).ThenBy(person => person.LastName);

            foreach (var item in finalOrder)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
