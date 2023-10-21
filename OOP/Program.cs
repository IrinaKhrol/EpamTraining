namespace OOP
{
    public class Program
    {
          static void Main(string[] args)
        {

            Car bently = new Car("sport",
                         new Engine(500, 6.0, "Gasoline AI-95", "JM3LW28A520306187"),
                         new Chassis(4, "NB989", 20),
                         new Transmission("automatic", 8, "Bentley Motors Ltd."));

            Bus bus = new Bus(25,
                      new Engine(60, 5.1, "diesel", "621321AC"),
                      new Chassis(6, "VIN157", 35),
                      new Transmission("manual", 5, "MAZ"));

            Truck truck = new Truck("cabover",
                          new Engine(500, 11.8, "diesel", "K54367E"),
                          new Chassis(4, "UTV678", 50),
                          new Transmission("automatic", 16, "Mercedes Benz"));

            Scooter scooter = new Scooter("Cjo",
                  new Engine(89, 5.8, "diesel", "LKJ87"),
                  new Chassis(2, "VBN5609", 12),
                  new Transmission("automatic", 2, "Ducati"));

            List<Vehicle> vehicles = new List<Vehicle>() { bently, bus, truck, scooter };


            List<Vehicle> vehiclesWithEngine = vehicles.Where(x => x.Engine.Volume > 1.5).ToList();

            List<Vehicle> listOfBusesAndTrucks = vehicles.OfType<Bus>().Union<Vehicle>(vehicles.OfType<Truck>()).ToList();

            var vehiclesWithTypeEngineAndChassis = listOfBusesAndTrucks.Select(x=> x.Engine).ToList();

            var vehiclesWithTransmission = vehicles.GroupBy(x => x.Transmission.TransmissionType).ToList();



            Serializer.SerializeXML(vehiclesWithEngine, "EngineVolume.XML");

            Serializer.SerializeXML(vehiclesWithTransmission, "Transmission");

            Serializer.SerializeXML(vehiclesWithTypeEngineAndChassis, "EngineNumberPowerAllBusesAndTrucks");
        }
    }
}