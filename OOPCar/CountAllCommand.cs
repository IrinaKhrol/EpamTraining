using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCar
{
    public class CountAllCommand: Command
    {
        private readonly CarDatabase _database;

        public CountAllCommand(CarDatabase database)
        {
            _database = database;
        }

        public override void Execute()
        {
            Console.WriteLine($"Total number of cars: {_database.GetTotalCars()}");
        }
    }
}
