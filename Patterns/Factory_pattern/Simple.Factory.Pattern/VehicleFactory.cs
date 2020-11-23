namespace Factory_pattern
{
    public class VehicleFactory
    {
        public static IVehicle Create(int vehicleType)
        {
            return vehicleType switch
            {
                0 => new Boat(),
                1 => new Motorbike(),
                2 => new Car(),
                _ => new Car(),
            };
        }
    }
}
