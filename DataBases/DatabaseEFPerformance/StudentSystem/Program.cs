namespace StudentSystem
{
    using System;
    using System.Linq;
    using System.Diagnostics;
   
    class Program
    {
        static void Main(string[] args)
        {
            
            var db = new TelerikAcademyEntities();

            var employees = db.Employees;

             //Slow way. Do not use it :) 
            var watch = Stopwatch.StartNew();
            foreach (var employee in employees)
            {
                var name = employee.FirstName;
                var deparment = employee.Department.Name;
                var town = employee.Address.Town;
            }
            watch.Stop();
            Console.WriteLine("Slow way {0} miliseconds", watch.Elapsed.TotalMilliseconds);

            // Include() way. Just one query present in profiler

            var newWatch = Stopwatch.StartNew();
            foreach (var employee in employees.Include("Department").Include("Address.Town"))
            {
                var name = employee.FirstName;
                var department = employee.Department.Name;
                var town = employee.Address.Town;
            }
            newWatch.Stop();
            Console.WriteLine("Fast way {0} miliseconds", newWatch.Elapsed.Milliseconds );

            var selectedItem = db.Employees.Select(x => new
            {
                Name = x.FirstName,
                Depart = x.Department.Name,
                Town = x.Address.Town
            });

            var clock = Stopwatch.StartNew();
            foreach (var item in selectedItem)
            {
                var name = item.Name;
                var department = item.Depart;
                var town = item.Town;
            }
            clock.Stop();
            Console.WriteLine("Lambda way {0} miliseconds", clock.Elapsed.Milliseconds);
        }

    }
}
