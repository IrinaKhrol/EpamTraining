namespace OOPCar
{
    public class CountTypesCommand: Command
    {
        public CarDatabase _database;
        public Func<object> carDb;

        public CountTypesCommand(CarDatabase database)
        {
            _database = database;
        }

        public CountTypesCommand(Func<object> carDb)
        {
            this.carDb = carDb;
        }

        public override void Execute()
        {
            Console.WriteLine($"Number of car brands: {_database.GetBrands().Count}");
        }
    }
}
