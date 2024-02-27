namespace OOPCar
{
    public class CarDatabase
    {
        private static CarDatabase? _instance;
        private readonly List<Car> _cars;

        private CarDatabase()
        {
            _cars = new List<Car>();
        }

        public static CarDatabase GetInstance()
        {
                if (_instance == null)
                    _instance = new CarDatabase();
                return _instance;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public HashSet<string> GetBrands()
        {
            var brands = new HashSet<string>();
            foreach (var car in _cars)
            {
                brands.Add(car.Brand);
            }
            return brands;
        }

        public int GetTotalCars()
        {
            int total = 0;
            foreach (var car in _cars)
            {
                total += car.Quantity;
            }
            return total;
        }

        public double GetAveragePrice()
        {
            double totalCost = 0;
            int totalQuantity = 0;
            foreach (var car in _cars)
            {
                totalCost += car.Cost * car.Quantity;
                totalQuantity += car.Quantity;
            }
            return totalQuantity > 0 ? totalCost / totalQuantity : 0;
        }

        public double GetAveragePriceByBrand(string brand)
        {
            double totalCost = 0;
            int totalQuantity = 0;
            foreach (var car in _cars)
            {
                if (car.Brand == brand)
                {
                    totalCost += car.Cost * car.Quantity;
                    totalQuantity += car.Quantity;
                }
            }
            return totalQuantity > 0 ? totalCost / totalQuantity : 0;
        }
    }
}
