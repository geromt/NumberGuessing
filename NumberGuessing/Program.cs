namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Guessing");
            Random random = new Random();
            int winnerNumber = random.Next(0, 101);
            int guessedNumber;
            int triesCount = 6;

            while (triesCount > 0)
            {
                Console.WriteLine(string.Format("Guess a number, you've {0} tries left:", triesCount));
                var inputNumber = Console.ReadLine();

                if (!int.TryParse(inputNumber, out guessedNumber))
                {
                    Console.WriteLine("Input an integer number, please");
                    continue;
                }

                if (guessedNumber > winnerNumber)
                    Console.WriteLine("To High. Try with a lower one...");
                else if (guessedNumber < winnerNumber)
                    Console.WriteLine("To Low. Try with a higher one...");
                else
                    break;

                triesCount--;
            }

            if (triesCount == 0)
                Console.WriteLine("You lose");
            else
            {
                Console.WriteLine("Congratulations! You've guess the right number");
                Console.WriteLine(string.Format("You only take {0} tries", triesCount));
            }

            Console.ReadLine();
        }
    }
}
