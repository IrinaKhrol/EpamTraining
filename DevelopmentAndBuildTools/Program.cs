namespace DevelopmentAndBuildTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();

            //Message m = new Message();
            Console.WriteLine(Message.GetString(input));
        }
    }
}