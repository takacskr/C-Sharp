using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who guess? You or the Machine? (y/m)");
            char whoGuess = Console.ReadKey(true).KeyChar;
            Random random = new Random();

            if (whoGuess == 'y')
            {
                bool continueTheGame = true;
                do
                {
                    int randomNumber = random.Next(1, 101);
                    Console.Write("Give a number 1-100: ");

                    for (int i = 5; i > 0; i--)
                    {
                        string numberInput = Console.ReadLine();

                        if (int.TryParse(numberInput, out int guessNumber) && (i != 0))
                        {
                            if (randomNumber > guessNumber)
                            {
                                Console.WriteLine($"The number is lager than yours.\nYou still have {i - 1} tries left.");
                            }
                            else if (randomNumber < guessNumber)
                            {
                                Console.WriteLine($"The number is smaller than yours.\nYou still have {i - 1} tries left.");
                            }
                            else
                            {
                                Console.WriteLine("Congratulations!, you win.");
                                i = 0;
                            }
                        }

                    }

                    Console.WriteLine("Game over. Do you stay in game? (y/n)");

                    if (Console.ReadKey(true).KeyChar == 'n')
                    {
                        Console.WriteLine("Good bye!");
                        continueTheGame = false;
                    }

                } while (continueTheGame);

                Console.ReadKey();
            } else if{

            }
        }
    }
}