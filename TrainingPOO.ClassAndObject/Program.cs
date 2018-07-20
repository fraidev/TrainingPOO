using System;

namespace TrainingPOO.ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //car is object
            //Car is a class
            //Class instantiates an object
            var car = new Car("Fusca");
            
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            car.Acelerate();
            
            Console.WriteLine(car.Name);
            Console.WriteLine(car.Year);
            Console.WriteLine(car.Velocity);
        }
    }
}