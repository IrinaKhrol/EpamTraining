namespace BasicOf.NETFramevorkAndCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = "0123456789ABCDEFGHIJ";
            string result = string.Empty;

            Console.WriteLine("Enter an integer in decimal notation");

            var integer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the base of the new number system");

            var baseNumbers = Convert.ToInt32(Console.ReadLine());


            while (integer >= baseNumbers)
            {
                var number1 = integer % baseNumbers;
                integer = integer / baseNumbers;
                result = values[number1] + result;
            }

            result = values[integer] + result;

            Console.WriteLine(result);
        }
    }
}