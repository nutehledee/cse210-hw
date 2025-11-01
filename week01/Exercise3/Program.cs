using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        Random randomGenerator = new Random();

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guesses = 0;
            int guess;

            Console.WriteLine($"[DEBUG] Magic number is: {magicNumber}"); // REMOVE LATER

            do
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // PREVENT CRASH
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a number!");
                    continue;
                }

                guesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"It took you {guesses} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}