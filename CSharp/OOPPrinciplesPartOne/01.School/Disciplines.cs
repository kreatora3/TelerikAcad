namespace _01.School
{
    public class Disciplines : IComment
    {
        private string comment;

        public Disciplines(string name, int numOflectures, int numOfexcersises)
        {
            this.Name = name;
            this.NumOfExercises = numOfexcersises;
            this.NumOfLectures = numOflectures;
        }
    
        public string Name { get; private set; }

        public int NumOfLectures { get; set; }

        public int NumOfExercises { get; set; }

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
            return string.Format("{0}  {1} lectures  {2} excersises", this.Name, this.NumOfLectures, this.NumOfExercises);
        }
    }
}
