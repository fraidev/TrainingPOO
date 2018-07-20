using System;
 
 namespace TrainingPOO.Polymorphism
 {
     class Program
     {
         static void Main(string[] args)
         {
             var car = new Car();
             var airplane = new Airplane();

             car.setVelocity(110);
             car.setPassengers(5);

             airplane.setVelocity(300);
             airplane.setPassengers(50);
         }
     }
 }