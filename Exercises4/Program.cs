namespace Exercises4
{
    class Program
    {
        static int countHeads;
        static int countTails;
        static string name;
        static void Main(string[] args)
        {
            getName();
            CoinToss();
        }
        static void CoinToss()
        {
            countHeads = 0;
            countTails = 0;
            Random random = new Random();
            Console.WriteLine("Tossing a coin...");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Round " + (i + 1) + " ");
                if (random.Next(0, 2) == 0)
                {
                    Console.WriteLine("Heads");
                    countHeads++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    countTails++;
                }
            }
            Console.WriteLine("Heads: " + countHeads + ", Tails: " + countTails);
        }
        static void getName()
        {
            Console.WriteLine("Who are you?");
            Console.Write("> ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}