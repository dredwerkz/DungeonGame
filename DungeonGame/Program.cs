namespace DungeonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World! Say something: ");
            var readLine = Console.ReadLine();
            Console.WriteLine($"You typed {readLine}");
        }
    }
}
