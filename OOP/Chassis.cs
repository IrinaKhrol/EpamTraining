namespace OOP
{
    public class Chassis
    {
        public int NumberOfWheels { get; set; }

        public string ChassisNumber { get; set; }

        public int LoadCapacity { get; set; }

        public Chassis(int numberOfWheels, string chassisNumber, int loadCapacity)
        {
            NumberOfWheels = numberOfWheels;
            ChassisNumber = chassisNumber;
            LoadCapacity = loadCapacity;
        }

        public string GetInformationAboutChassis()
        {
            return $"'Chassis' - Number Of Wheels: {NumberOfWheels}, Chassis Number: {ChassisNumber}, Load Capacity: {LoadCapacity}\n";
        }
    }
}
