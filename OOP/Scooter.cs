﻿namespace OOP
{
    internal class Scooter : Vehicle
    {
        public string FirmScooter { get; set; }
        public Scooter(string firmScooter, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            FirmScooter = firmScooter;
        }

        public override string GetAllInformation()
        {
            return $"Scooter\nFirm Scooter: {FirmScooter}\n" + base.GetAllInformation();
        }
    }
}
