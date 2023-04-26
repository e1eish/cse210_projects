using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        bool isPlaying = true;
        while (isPlaying)
        {
            int guess;
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine(number);
            int guessCount = 1;
            do
            {
                Console.Write("Enter guess: ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                if (guess == number)
                {
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                guessCount ++;
            } while (guess != number);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.\n");

            Console.Write("Do you want to keep playing (yes/no)? ");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                {}
            }
            else
            {
                isPlaying = false;
            }
        }
        Console.WriteLine("Thank you for playing. Goodbye.\n");
    }
}