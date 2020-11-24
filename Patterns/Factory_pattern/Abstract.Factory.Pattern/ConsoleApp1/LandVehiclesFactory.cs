namespace Abstract.Factory.Pattern
{
    public class LandVehiclesFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle(int specificVehicle)
        {
            return specificVehicle switch
            {
                0 => new Motorbike(),
                _ => new Car(),
            };
        }
    }
}
