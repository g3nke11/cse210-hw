using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int perc = int.Parse(answer);

        string letter = "";

        if (perc >= 90)
        {
            letter = "A";
        }
        else if (perc >= 80)
        {
            letter = "B";
        }
        else if (perc >= 70)
        {
            letter = "C";
        }
        else if (perc >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");
        if (perc >= 70)
        {
            Console.WriteLine("You passed! Congratulation!");
        }
        else 
        {
            Console.WriteLine("Too bad. Better luck next time.");
        }
    }
}