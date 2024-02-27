using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCar
{
    class AveragePriceTypeCommand: Command
    {
        private readonly CarDatabase _database;
        private readonly string _brand;

        public AveragePriceTypeCommand(CarDatabase database, string brand)
        {
            _database = database;
            _brand = brand;
        }

        public override void Execute()
        {
            Console.WriteLine($"Average price for {_brand}: {_database.GetAveragePriceByBrand(_brand):C}");
        }
    }
}
