using System;

namespace GuessTheNumberApp
{
    class GuessTheNumber
    {
        private Random random = new Random();

        public void oneRoundPlaying()
        {
            int triesLeft = 5;

            do
            {
                string tip = Console.ReadLine();
                int guessedNumber = 0;
                int machineNumber = random.Next(1, 101);

                if (int.TryParse(tip, out guessedNumber))
                {
                    HandleGuess(guessedNumber, machineNumber, ref triesLeft);
                }

            } while (triesLeft > 0);
        }

        private void HandleGuess(int guessedNumber, int machineNumber, ref int triesLeft)
        {
            Console.WriteLine(guessedNumber);

            if (machineNumber > guessedNumber)
            {
                Console.WriteLine("The number is higher than yours.");
            }
            else if (machineNumber < guessedNumber)
            {
                Console.WriteLine("The number is lower than yours.");
            }
            else
            {
                Console.WriteLine("You win!");
                return;
            }

            --triesLeft;
            Console.Write($"You have {triesLeft} tries left. ");
        }

        public void HumanGuess()
        {
            bool isStayInGame = true;

            do
            {
                Console.Write("Guess a number. It should be 1-100. :");

                oneRoundPlaying();

                Console.Write("\nAre you stay in game? (y/n)\n");

                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    Console.WriteLine("Good bye!");
                    isStayInGame = false;
                }

            } while (isStayInGame);
        }
        public void MachineGuess()
        {
            Console.WriteLine("Machine guess.");
        }

        public void StartTheGame()
        {
            Console.WriteLine("Who is guess? You or the Machine? (y/m)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                HumanGuess();
            }
            else
            {
                MachineGuess();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumber game = new GuessTheNumber();
            game.StartTheGame();
        }
    }
}
