namespace OOP
{
     public class Car : Vehicle
    {
        public string CarType { get; set; }
        public Car(string carType, Engine Engine, Chassis Chassis, Transmission Transmission) : base(Engine, Chassis, Transmission)
        {
            CarType = carType;
        }

        public override string GetAllInformation()
        {
            return $"Car\nCar Type: {CarType}\n" + base.GetAllInformation();
        }
    }
}
