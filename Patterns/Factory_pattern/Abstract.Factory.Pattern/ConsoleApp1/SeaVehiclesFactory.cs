namespace Abstract.Factory.Pattern
{
    public class SeaVehiclesFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle(int specificVehicle)
        {
            return specificVehicle switch
            {
                _ => new Boat(),
            };
        }
    }
}
