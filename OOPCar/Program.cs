namespace OOPCar
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carDb = CarDatabase.GetInstance();
            // Example of adding cars to the database
            carDb.AddCar(new Car("Toyota", "Camry", 10, 25000));
            carDb.AddCar(new Car("Honda", "Civic", 15, 22000));

            List<Car> cars = new List<Car>();
            while (true)
            {
                Console.WriteLine("Enter car information or type 'done' to finish:");
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                if (brand.ToLower() == "done")
                    break;

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Quantity: ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value.");
                    Console.Write("Quantity: ");
                }

                Console.Write("Cost per unit: ");
                double cost;
                while (!double.TryParse(Console.ReadLine(), out cost))
                {
                    Console.WriteLine("Invalid input. Please enter a valid double value.");
                    Console.Write("Cost per unit: ");
                }

                cars.Add(new Car (brand, model, quantity,cost ));

                Console.WriteLine("Car information added successfully.");
                Console.WriteLine();
            }

            Console.WriteLine("Commands available:");
            Console.WriteLine("- count types");
            Console.WriteLine("- count all");
            Console.WriteLine("- average price");
            Console.WriteLine("- average price type [brand]");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter a command: ");
                string command = Console.ReadLine().ToLower();

                if (command == "count types")
                {
                    int countTypes = cars.Select(c => c.Brand).Distinct().Count();
                    Console.WriteLine("Number of car brands: " + countTypes);
                }
                else if (command == "count all")
                {
                    int countAll = cars.Sum(c => c.Quantity);
                    Console.WriteLine("Total number of cars: " + countAll);
                }
                else if (command == "average price")
                {
                    double averagePrice = cars.Any() ? cars.Average(c => c.Cost) : 0;
                    Console.WriteLine("Average cost of the cars: " + averagePrice);
                }
                else if (command.StartsWith("average price type"))
                {
                    string brand = command.Substring("average price type".Length).Trim();
                    double averagePriceType = cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                                                  .Average(c => c.Cost);
                    Console.WriteLine($"Average cost of {brand} cars: " + averagePriceType);
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}