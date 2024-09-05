using System;


namespace ACT1
{
    public class Trainer
    {
        public string Name { get; set; }

        public Trainer(string name)
        {
            Name = name;
        }

        public virtual void Greet()
        {
            Console.WriteLine($"{Name} Hi");
        }
    }
}