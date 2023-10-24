namespace NETCollections
{
    [Serializable]
    public class Engine
    {
        public int Power { get; set; }

        public double Volume { get; set; }

        public string Type { get; set; }

        public string SerialNumber { get; set; }

        public Engine()
        {

        }

        public Engine(int power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public string GetInformationAboutEngine()
        {
            return $"'Engine' - Power: {Power}, Volume: {Volume}, Type: {Type}, Serial Number: {SerialNumber}\n";
        }
    }
}
