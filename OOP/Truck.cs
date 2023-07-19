namespace OOP
{
    public class Truck : Vehicle
    {
        public string СabinType { get; set; }
        public Truck(string сabinType, Engine Engine, Chassis Chassis, Transmission Transmission) : base(Engine, Chassis, Transmission)
        {
            СabinType = сabinType;
        }

        public override string GetAllInformation()
        {
            return $"Truck\nCabin Type: {СabinType}\n" + base.GetAllInformation();
        }
    }
}
