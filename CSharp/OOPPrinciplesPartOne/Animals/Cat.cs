﻿namespace Animals
{
    public abstract class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public abstract override string ToString();
    }
}
