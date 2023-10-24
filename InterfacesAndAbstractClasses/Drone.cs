namespace InterfacesAndAbstractClasses
{
    internal class Drone : FlyingObject, IFlyable
    {

        const int MinSpeedKm = 50;
        const int MaxSpeedKm = 300;
        const double FreezeTime = 0.0166666; // 1min = 1/60h = 0.0166666h (time the drone hangs in the air)
        const double IntervalTimeBeforeFreeze = 0.166666; // 10 min = 1/6h = 0.166666h(time interval after which the drone hovers in the air again)
        const int MaxDistance = 500;// maximum possible flight distance of the drone

        public Drone(Coordinate currentCoordinate)
        {
            this.currentCoordinate = currentCoordinate;
            this.speed = MinSpeedKm;
        }

        public Drone()
        {
            this.speed = GetSpeed();
        }

        private int GetSpeed()
        {
            Random rnd = new Random();
            return rnd.Next(MinSpeedKm, MaxSpeedKm);
        }

        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Math.Round(GetDistance(newCoordinate), 2);

            if (ValidateMaxDistance(newCoordinate))
            {
                CurrentCoordinate = newCoordinate;
            }
            else
            {
                Console.WriteLine($"New Coordinate can't be reached out by the drone due to the dictance = {distance} exceeds the Max Distance restriction = {MaxDistance} km");
            }
            CurrentCoordinate = newCoordinate;
        }

        public double GetFlyTime(Coordinate newCoordinate)
        {
            double distance = GetDistance(newCoordinate);
            double timeWithoutFreezes = distance / Speed; // flight time without hovering in hours
            int freezes = (int)(timeWithoutFreezes / IntervalTimeBeforeFreeze);// total number of hovering in the air
            return Math.Round(timeWithoutFreezes + (freezes * FreezeTime), 2);// total flight time = free flight time + (number of hangs multiplied by the time of one hang)
        }

        public bool ValidateMaxDistance(Coordinate newCoordinate)
        {
            return (GetDistance(newCoordinate) >= MaxDistance) ? false : true;
        }
    }
}
