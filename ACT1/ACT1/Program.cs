using System;

namespace ACT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input trainer name: ");
            string trainerName = Console.ReadLine();

            Console.Write("¿Friendly trainer (Y/N): ");
            string isFriendly = Console.ReadLine().ToLower();

            Trainer trainer;
            if (isFriendly == "sí" || isFriendly == "si")
            {
                trainer = new FriendNPC(trainerName);
            }
            else
            {
                trainer = new Trainer(trainerName);
            }

            trainer.Greet();
            Console.ReadLine();
        }
    }
}
