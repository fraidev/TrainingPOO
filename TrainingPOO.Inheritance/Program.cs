using System;
using TrainingPOO.Inheritance.Domains;

namespace TrainingPOO.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var airplane = new Airplane();

            car.Velocity =110;
            car.Passengers = 5;

            airplane.Velocity = 300;
            airplane.Passengers = 50;
             
            Console.WriteLine(car.Velocity);
            Console.WriteLine(car.Passengers);
             
            Console.WriteLine(airplane.Velocity);
            Console.WriteLine(airplane.Passengers);
        }
    }
}