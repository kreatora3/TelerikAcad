namespace Animals
{
    using System;

   public class Dog : Animal
    {
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale) 
        { 
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} year old {2} dog");
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Bau!");
        }
    }
}
