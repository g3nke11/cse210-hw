using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess_int = -1;

        while (guess_int != magic_number)
        {
        Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        guess_int = int.Parse(answer);
        if (guess_int < magic_number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess_int > magic_number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        }
    }
}