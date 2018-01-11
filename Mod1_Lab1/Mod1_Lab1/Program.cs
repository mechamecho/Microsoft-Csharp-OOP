using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of Car() Class using Type Inference called Car1
            var Car1 = new Car();

            //Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //Output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}," +
                              $" and has {Car1.Mileage} miles on it.");
        }
    }
}
