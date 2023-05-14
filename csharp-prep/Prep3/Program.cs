using System;

class Program
{
    static void Main(string[] args)
    { 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("What is your guess?");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);

        while (guess != number)
        {
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            
            
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your guess?");
            answer = Console.ReadLine();
            guess = int.Parse(answer);
        }

        Console.WriteLine("Correct");
    }
}