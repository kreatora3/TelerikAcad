﻿namespace BankSystem
{
    public abstract class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
