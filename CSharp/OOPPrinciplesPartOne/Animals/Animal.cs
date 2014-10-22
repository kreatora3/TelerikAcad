namespace Animals
{
    using System;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;

            this.Age = age;

            this.IsMale = isMale;
        }

       

        public string Name { get; private set; }

        public int Age { get; private set; }

        public bool IsMale { get; private set; }

        public abstract override string ToString();

        public static double AverageAge(Animal[] creatures)
        {
            var result = creatures.Average(x => x.Age);

            return result;
        }

        public virtual void MakeSomeNoise()
        {
            Console.WriteLine("Noise!");
        }
    }
}
