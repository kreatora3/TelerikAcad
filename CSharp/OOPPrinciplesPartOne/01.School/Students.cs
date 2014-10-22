namespace _01.School
{
    public class Students : People, IComment
    {
        private string comment;

        public Students(string name, int number)
        {
            this.Name = name;
            this.UniqueClassNumber = number;
        }

        public int UniqueClassNumber { get; private set; }

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
            return string.Format("{0} - UCNumber - {1}", this.Name, this.UniqueClassNumber);
        }
    }
}
