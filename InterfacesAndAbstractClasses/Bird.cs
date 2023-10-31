namespace InterfacesAndAbstractClasses
{
    public class Bird : FlyingObject, IFlyable
    {
        private const int MinSpeedKm = 1;
        private const int MaxSpeedKm = 20;

        public Bird(Coordinate currentCoordinate)
        {
            this.currentCoordinate = currentCoordinate;
            this.speed = GetSpeed();
        }

        public Bird()
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
            CurrentCoordinate = newCoordinate;
        }

        public double GetFlyTime(Coordinate newCoordinate)
        {
            double distance = GetDistance(newCoordinate);
            return Math.Round(distance / Speed, 2);
        }
    }
}
