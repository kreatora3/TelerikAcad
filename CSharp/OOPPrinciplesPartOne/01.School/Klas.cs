namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Klas : IComment
    {
        private List<Teachers> teachers;
        private string comment;

        public Klas(string textIdentifier, List<Teachers> assignedTeachers)
        {
            this.TextIdentifier = textIdentifier;
            this.teachers = new List<Teachers>(assignedTeachers);
        }

        public List<Teachers> TeachersSet
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public string TextIdentifier { get; private set; }

        public string OptionalComment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Klas {0}", this.TextIdentifier);
        }
    }
}
