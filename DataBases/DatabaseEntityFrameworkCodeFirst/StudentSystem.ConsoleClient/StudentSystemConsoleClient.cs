using StudentSystem.Data;
using StudentSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Data.Migrations;

namespace StudentSystem.ConsoleClient
{
    class StudentSystemConsoleClient
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            var db = new StudentSystemDbContext();

            var student = new Student
            {
                Age = 30,
                FirstName = "Pesho",
                LastName = "Goshov",
                StudentStatus = StudentStatus.Online
            };

            student.Courses.Add(new Course
            {
                Name = "Entity Framework"
            });
            db.Students.Add(student);
            db.SaveChanges();

            var savedStudent = db.Students.First();
            Console.WriteLine(savedStudent.Id + ": " + savedStudent.FirstName + " " + savedStudent.LastName);
        }
    }
}
