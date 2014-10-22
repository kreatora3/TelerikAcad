namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teachers : People, IComment
    {
        private List<Disciplines> disciplines;
        private string comment;

        public Teachers(string name,  List<Disciplines> disciplines)
        {
            this.Name = name;
            this.disciplines = new List<Disciplines>(disciplines);
        }

        public List<Disciplines> DisciplinesSet
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

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
            return string.Format("{0} - Disciplines:\r\n{1}", this.Name, string.Join("\r\n", this.disciplines));
        }
    }
}
