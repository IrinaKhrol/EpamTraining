namespace OOP
{
    [Serializable]
    public class Transmission
    {
        public string TransmissionType { get; set; }

        public int NumberOfGears { get; set; }

        public string Manufacturer { get; set; }

        public Transmission()
        {
        }

        public Transmission(string transmissionType, int numberOfGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetInformationAboutTransmission()
        {
            return $"'Transmission' - Transmission Type: {TransmissionType}, Number Of Gears: {NumberOfGears}, Manufacturer: {Manufacturer}  ";
        }
    }
}
