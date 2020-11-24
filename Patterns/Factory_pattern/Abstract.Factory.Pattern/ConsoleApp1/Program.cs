using System;

namespace Abstract.Factory.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating vehicles");
            
            var seaVehicles = VehicleFactory.Create(0);
            //MotorbikeFactory().Create();
            Console.WriteLine($"Vehicle factory type: {seaVehicles.GetType().Name }" );
            var boatIndex = 0;
            var boat = seaVehicles.CreateVehicle(boatIndex);
            Console.WriteLine($"Number of wheels { boat.GetWheels() }");

            var landVehicles = VehicleFactory.Create(1);
            Console.WriteLine($"Vehicle factory type: {landVehicles.GetType().Name }");
           
            var motorbikeIndex = 0;
            var carIndex = 1;
            var motorbike = landVehicles.CreateVehicle(motorbikeIndex);
            var car = landVehicles.CreateVehicle(carIndex);
            Console.WriteLine($"Number of wheels { motorbike.GetWheels() }");
            Console.WriteLine($"Number of wheels { car.GetWheels() }");

        }
    }
}
