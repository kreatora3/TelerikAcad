namespace StudentClass
{
    using System;
    using System.Text;

     public class Student : ICloneable, IComparable<Student>
    {
        public Student()
        {
        }

        public Student(string firstName, string midName, string lastName, int ssn, string adress, string cellPhone, string email, int course, Specialty spec, Faculty faculty, University uni)
        {
            this.FirstName = firstName;
            this.MidName = midName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Adress = adress;
            this.CellPhone = cellPhone;
            this.EMail = email;
            this.Course = course;
            this.Spec = spec;
            this.Uni = uni;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }

        public string MidName { get; set; }

        public string LastName { get; set; }

        public int Ssn { get; set; }

        public string Adress { get; set; }

        public string CellPhone { get; set; }

        public string EMail { get; set; }

        public int Course { get; set; }

        public Specialty Spec { get; set; }

        public University Uni { get; set; }

        public Faculty Faculty { get; set; }
       
        public static bool operator ==(Student stud1, Student stud2)
        {
            if (ReferenceEquals(stud1, stud2))
            {
                return true;
            }

            if (((object)stud1 == null) || ((object)stud2 == null))
            {
                return false;
            }

            return stud1.Ssn == stud2.Ssn;
        }

        public static bool operator !=(Student stud1, Student stud2)
        {
            return !(stud1 == stud2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MidName, this.LastName));
            sb.AppendLine(string.Format("SSN: {0}", this.Ssn));
            sb.AppendLine(string.Format("University: {0}, Faculty: {1}, Specialty: {2}, Course: {3}", this.Uni, this.Faculty, this.Spec, this.Course));
            return sb.ToString();
        }

        public object Clone()
        {
            Student newStudent = new Student(this.FirstName, this.MidName, this.LastName, this.Ssn, this.Adress, this.CellPhone, this.EMail, this.Course, this.Spec, this.Faculty, this.Uni);
            return newStudent;
        }

        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }

            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MidName != other.MidName)
            {
                return this.MidName.CompareTo(other.MidName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.Ssn != other.Ssn)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            return this.Ssn == student.Ssn;
        }

        public override int GetHashCode()
        {
            return this.Ssn ^ this.Course;
        }
    }
}
