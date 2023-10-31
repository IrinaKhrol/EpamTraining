namespace InterfacesAndAbstractClasses
{
    public class Airplane : FlyingObject, IFlyable
    {
        private const int MinSpeedKm = 200;
        private const int MaxSpeedKm = 5000;
        private const int SpeedIncrease = 10; // step of increasing speed for each section of the path flown
        private int SpeedPath = 10; // the distance during which an airplane increases its speed
        private int MaxDistance = 2000;// maximum possible flight distance of an aircraft in 1 flight

        public Airplane(Coordinate currentCoordinate)
        {
            this.currentCoordinate = currentCoordinate;
            this.speed = MinSpeedKm;
        }

        public Airplane()
        {
            this.speed = MinSpeedKm;
        }

        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Math.Round(GetDistance(newCoordinate), 2);
            // Validate the new coordinate so that the distance does not exceed the max distance

            if (ValidateNewCoordinate(newCoordinate))
            {
                var passedDistanceByPlane = 0;
                // determine the speed achieved in flight (until the distance traveled exceeds the length of the path, increase the speed every 10 km by 10 km/h

                while (passedDistanceByPlane <= distance)
                {
                    Speed += SpeedIncrease;
                    passedDistanceByPlane += SpeedPath;
                }


                Console.WriteLine($"Distance: {distance} km. During the flight I increased my speed to {speed} from 1000 km/h");

                CurrentCoordinate = newCoordinate;
            }
            else
            {
                Console.WriteLine($"New Coordinate can't be reached out by the plane due to the dictance {distance} exceeds the Max Distance restriction = {MaxDistance} km");
            }
        }


        public double GetFlyTime(Coordinate newCoordinate)
        {
            Speed = MinSpeedKm;
            double flyTime = 0;
            double fullDistance = GetDistance(newCoordinate);
            double remainingDistance = fullDistance;
            // calculate the travel time as the sum of all flight times on each section of 10 km in length.
            // on each subsequent section of 10 km in length, we increase the speed by 10 km/h until we reach 1000 km/h or the remaining flight distance is less than 10 km

            while ((Speed < MaxSpeedKm) && (remainingDistance > SpeedPath))
            {
                Speed += SpeedIncrease;// increase the speed by 10 km / h
                flyTime += (double)SpeedPath / (double)(Speed);// determine the time during which the plane flew the next 10 km long section at the current speed
                remainingDistance -= SpeedPath;// reduce the remaining distance by the length of the next distance of 10 km
            }
            // the remaining distance the aircraft flies at maximum speed, but not more than 1000 km / h
            if (remainingDistance > 0)
            {
                flyTime += remainingDistance / (Speed);
            }
            return Math.Round(flyTime, 2);
        }


        public bool ValidateNewCoordinate(Coordinate newCoordinate)
        {
            return (GetDistance(newCoordinate) >= (MaxDistance - PassedDistance)) ? false : true;
        }
    }
}
