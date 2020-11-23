namespace Factory.Method.Pattern
{
    public abstract class VehicleFactory
    {
        protected abstract IVehicle CreateVehicle();

        public IVehicle Create()
        {
            return this.CreateVehicle();
        }
        
    }
}
