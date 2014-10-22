namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} year old {2}", this.Name, this.Age, this.GetType().Name);
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Mrrr myauu");
        }
    }
}
