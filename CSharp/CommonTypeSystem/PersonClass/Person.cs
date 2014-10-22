namespace PersonClass
{
    /* Create a class Person with two fields – name and age. 
     Age can be left unspecified (may contain null value. Override ToString() 
     to display the information of a person and if age is not specified – to say so. 
     Write a program to test this functionality. */

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age != null)
            {
                return string.Format("{0} is {1} year old", this.Name, this.Age);
            }

            return string.Format("{0}'s age is unknown", this.Name);
        }
    }
}
