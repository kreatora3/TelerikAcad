namespace Animals
{
    using System;

   public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, false)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} year old {2}", this.Name, this.Age, this.GetType().Name);
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Meooow");
        }
    }
}
