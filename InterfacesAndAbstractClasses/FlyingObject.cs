namespace InterfacesAndAbstractClasses
{
    abstract class FlyingObject
    {
        protected Coordinate currentCoordinate;
        protected int speed;
        protected double passedDistance;


        protected int Speed { get { return speed; } set { speed = value; } }
        protected Coordinate CurrentCoordinate { get { return currentCoordinate; } set { currentCoordinate = value; } }
        protected double PassedDistance { get; set; } = 0;

        protected double GetDistance(Coordinate newCoordinate)
        {
            return Math.Round(Math.Sqrt(Math.Pow(newCoordinate.X - currentCoordinate.X, 2) +
                Math.Pow(newCoordinate.Y - currentCoordinate.Y, 2) +
                Math.Pow(newCoordinate.Z - currentCoordinate.Z, 2)),2) + PassedDistance;
        }

        public void PrintDistance(Coordinate newCoordinate)
        {
            Console.WriteLine($"The distance from the currect coordinate {currentCoordinate.PrintCoordinate()} to new coordinate: {newCoordinate.PrintCoordinate()} equals {GetDistance(newCoordinate)} km");
        }

    }
}
