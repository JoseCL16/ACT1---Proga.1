using System;

namespace ACT1
{
    public class BadNPC : Trainer
    {
        public BadNPC(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine($"{Name} Let's battle");
        }
    }
}