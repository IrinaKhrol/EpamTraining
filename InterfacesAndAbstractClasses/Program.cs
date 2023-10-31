namespace InterfacesAndAbstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coordinate newCoordinateBird = new Coordinate(5, 5, 5);

            Bird bird = new Bird();
            double birdFlyTime = bird.GetFlyTime(newCoordinateBird);
            Console.WriteLine("Bird Fly Time " + birdFlyTime.ToString() + " hours");
            bird.FlyTo(newCoordinateBird);
            Console.WriteLine();


            Coordinate newCoordinateAirplane1 = new Coordinate(100, 100, 100);

            Airplane airplane = new Airplane();

            double airplaneFlyTime = airplane.GetFlyTime(newCoordinateAirplane1);
            Console.WriteLine("Airplane Fly Time " + airplaneFlyTime.ToString() + " hours");

            airplane.PrintDistance(newCoordinateAirplane1);
            airplane.FlyTo(newCoordinateAirplane1);
            airplane.PrintDistance(newCoordinateAirplane1);

            Coordinate newCoordinateAirplane2 = new Coordinate(10000, 10000, 10000);

            double airplaneFlyTime2 = airplane.GetFlyTime(newCoordinateAirplane2);
            Console.WriteLine("Airplane Fly Time " + airplaneFlyTime2.ToString() + " hours");

            airplane.PrintDistance(newCoordinateAirplane2);
            airplane.FlyTo(newCoordinateAirplane2);
            airplane.PrintDistance(newCoordinateAirplane2);

            Coordinate newCoordinateDrone = new Coordinate(200, 200, 200);

            Drone drone = new Drone();
            double droneFlyTime = drone.GetFlyTime(newCoordinateDrone);
            Console.WriteLine("Drone Fly Time " + droneFlyTime.ToString() + " hours");
            drone.PrintDistance(newCoordinateDrone);
            drone.FlyTo(newCoordinateDrone);
            drone.PrintDistance(newCoordinateDrone);
        }
    }
}