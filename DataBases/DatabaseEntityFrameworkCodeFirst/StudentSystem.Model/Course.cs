namespace StudentSystem.Model
{
    using System;
using System.Collections.Generic;
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;
        public Course()
        {
            this.homeworks = new HashSet<Homework>();
            this.students = new HashSet<Student>();
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students 
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public ICollection<Homework> Homworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }
    }
}
