namespace Animals
{
    using System;

   public class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} year old {2} frog");
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Ribbit");
        }
    }
}
