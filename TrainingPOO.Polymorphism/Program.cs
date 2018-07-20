using System;
using TrainingPOO.Polymorphism.Domains;

namespace TrainingPOO.Polymorphism
 {
     class Program
     {
         static void Main(string[] args)
         {
             //Cannot create an INSTANCE of the Abstract class 
             //var vehicle = new Vehicle(); 
             
             var car = new Car();
             var airplane = new Airplane();

             car.setVelocity(110);
             car.setPassengers(5);

             airplane.setVelocity(300);
             airplane.setPassengers(50);
             
             Console.WriteLine(car.Velocity);
             Console.WriteLine(car.Passengers);
             
             Console.WriteLine(airplane.Velocity);
             Console.WriteLine(airplane.Passengers);
         }
     }
 }