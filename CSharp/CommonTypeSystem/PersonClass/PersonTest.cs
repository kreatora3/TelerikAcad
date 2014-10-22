namespace PersonClass
{
    using System;

    public class PersonTest
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho", 22);
            Person gosho = new Person("Gosho");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
