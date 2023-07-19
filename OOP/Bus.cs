namespace OOP
{
    public class Bus : Vehicle
    {
        public int SeatsNumber { get; set; }
        public Bus(int seatsNumber, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            SeatsNumber = seatsNumber;
        }

        public override string GetAllInformation()
        {
            return $"Bus\nSeats Number: {SeatsNumber}\n" + base.GetAllInformation() ;
        }
    }
}
