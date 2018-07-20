using System;

namespace TrainingPOO.Polymorphism.Domains
{
    public class Car:Vehicle
    {
        public override void DoSound(string sound)
        {
            Console.WriteLine("Vrum Vrum!");
        }
    }
}