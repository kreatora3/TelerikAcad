﻿namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Model;

    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            : base("StudentSystem")
        {

        }
        public IDbSet<Homework> Homeworks { get; set;}
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Course> Courses { get; set; }
    }
}
