using System.Xml.Serialization;

namespace NETCollections
{
    public static class Serializer
    {
        public static void SerializeXML(List<Vehicle> vehicles, string nameOfFile)

        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Vehicle));

            using (FileStream fs = new FileStream(nameOfFile, FileMode.OpenOrCreate))
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    xmlSerializer.Serialize(fs, vehicle);
                }

                Console.WriteLine("Object has been serialized");
            }
        }

        public static void SerializeXML(List<IGrouping<string, Vehicle>> vehiclesWithTransmission, string nameOfFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Vehicle));

            using (FileStream fs = new FileStream(nameOfFile, FileMode.OpenOrCreate))
            {
                foreach (var vehicle in vehiclesWithTransmission)

                { foreach (var t in vehicle)
                    { xmlSerializer.Serialize(fs, t); }
                }

                Console.WriteLine("Object has been serialized");
            }
        }

        internal static void SerializeXML(List<Engine> vehiclesWithTypeEngineAndChassis, string nameOfFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Engine));

            using (FileStream fs = new FileStream(nameOfFile, FileMode.OpenOrCreate))
            {
                foreach (Engine vehicle in vehiclesWithTypeEngineAndChassis)

                {
                    xmlSerializer.Serialize(fs, vehicle);
                }

                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
