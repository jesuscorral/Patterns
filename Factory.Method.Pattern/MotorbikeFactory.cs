namespace Factory.Method.Pattern
{
    public class MotorbikeFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Motorbike();
        }
    }
}