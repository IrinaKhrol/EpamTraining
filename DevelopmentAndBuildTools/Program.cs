namespace DevelopmentAndBuildTools
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();

            Console.WriteLine(Message.GetString(input));
        }
    }
}