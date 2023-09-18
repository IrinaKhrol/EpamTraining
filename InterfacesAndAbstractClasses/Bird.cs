namespace InterfacesAndAbstractClasses
{
    internal class Bird : FlyingObject, IFlyable
    {
        const int minSpeedKm = 1;
        const int maxSpeedKm = 20;

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
            return rnd.Next(minSpeedKm, maxSpeedKm);
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
