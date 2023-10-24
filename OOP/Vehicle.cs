namespace OOP
{
    public abstract class Vehicle

    {
        public Engine Engine { get; set; }

        public Chassis Chassis { get; set; }

        public Transmission Transmission { get; set; }

        public Vehicle (Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public virtual string GetAllInformation() 
        {
            return Engine.GetInformationAboutEngine() + "" + Chassis.GetInformationAboutChassis() + "" + Transmission.GetInformationAboutTransmission();
        }
    }
}