using System;

namespace Factory.Method.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating vehicles");

            var motorbike = new MotorbikeFactory().Create();
            Console.WriteLine($"Number of wheels { motorbike.GetWheels() }");

            var boat = new BoatFactory().Create();
            Console.WriteLine($"Number of wheels { boat.GetWheels() }");

            var car = new CarFactory().Create();
            Console.WriteLine($"Number of wheels { car.GetWheels() }");
        }
    }
}
