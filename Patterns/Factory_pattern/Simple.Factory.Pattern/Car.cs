using System;

namespace Factory_pattern
{
    public class Car : IVehicle
    {
        public int GetWheels()
        {
            return 4;
        }
    }
}