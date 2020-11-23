namespace Factory_pattern
{
    public interface IVehicleFactory
    {
        public IVehicle Create(int vehicleType);
    }
}
