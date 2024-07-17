using System;

class Program
{
    static void Main()
    {
        string[] choices = { "stone", "paper", "scissors" };
        Random random = new Random();

        Console.WriteLine("Choose: 0 for stone, 1 for paper, 2 for scissors");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        int computerChoice = random.Next(0, 3);

        Console.WriteLine($"You chose: {choices[userChoice]}");
        Console.WriteLine($"Computer chose: {choices[computerChoice]}");

        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == 0 && computerChoice == 2) ||
                 (userChoice == 1 && computerChoice == 0) ||
                 (userChoice == 2 && computerChoice == 1))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}
