using System;
using TrainingPOO.Overload.Domains;

namespace TrainingPOO.Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overload
            var calculator= new Calculator();
            Console.WriteLine(calculator.calculate(1,1));
            Console.WriteLine(calculator.calculate(2.0,6.1));
            Console.WriteLine(calculator.calculate("Sou"," Lindo"));
            
            //Overload Method
            Console.WriteLine(calculator.calculate("Ra", " Tim", " Bum!"));
            Console.WriteLine(calculator.calculate("We", " are", " the", " champions"));
            Console.WriteLine(calculator.calculate("Salada", " nao", " leva", " a", " nada"));
        }
    }
}