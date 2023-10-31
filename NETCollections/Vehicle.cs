using System.Xml.Serialization;

namespace NETCollections
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Truck))]
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }

        public Chassis Chassis { get; set; }

        public Transmission Transmission { get; set; }

        protected Vehicle()
        {
        }

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