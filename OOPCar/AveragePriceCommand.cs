using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCar
{
    public class AveragePriceCommand: Command
    {
        private CarDatabase _database;

        public AveragePriceCommand(CarDatabase database)
        {
            _database = database;
        }

        public override void Execute()
        {
            Console.WriteLine($"Average car price: {_database.GetAveragePrice():C}");
        }
    }
}
