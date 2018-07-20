using System;

namespace TrainingPOO.Polymorphism.Domains
{
    public class Airplane:Vehicle
    {
        public override void DoSound(string sound)
        {
            Console.WriteLine("ZUUUUUUUUUUUUUUUM!");
        }
    }
}