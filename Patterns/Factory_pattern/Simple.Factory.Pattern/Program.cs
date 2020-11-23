using System;

namespace Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating vehicles");

            // Version 1
            new Boat();
            new Car();
            new Motorbike();

            // Version 2: Cada tipo concreto de vehiculo hereda de la clase Vehiculo y en la factory,
            // se devuelve el vehiculo concreto en funcion del tipo que se pase a la factory. 
            // La creacion de nuevos tipos de vehiculos queda centralizada en la factory.
            for (int i = 0; i < 3; i++)
            {
               var vehicle = VehicleFactory.Create(i);
                Console.WriteLine($"Number of wheels { vehicle.GetWheels() }");
            }
        }
    }
}
