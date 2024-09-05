using System;

namespace ACT1
{
    public class FriendNPC : Trainer 
    {
        public FriendNPC(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine($"{Name} Hi, have a potion");
        }
    }
}