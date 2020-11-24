namespace Abstract.Factory.Pattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle(int specificVehicle);

        public static VehicleFactory Create(int vehicleGroup)
        {
            return vehicleGroup switch
            {
                0 => new SeaVehiclesFactory(),
                _ => new LandVehiclesFactory(),
            };
        }
        
    }
}
