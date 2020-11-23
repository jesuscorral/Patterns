namespace Factory.Method.Pattern
{
    public class BoatFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Boat();
        }
    }
}
