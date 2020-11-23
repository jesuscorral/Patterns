namespace Factory.Method.Pattern
{
    public class CarFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
