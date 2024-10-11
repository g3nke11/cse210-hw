using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        int option = 0;
        while(option != 5)
        {
            option = Menu();
            if(option == 1)
            {
                journal.AddEntry();
            }
            else if (option == 2)
            {
                journal.Display();
            }
            else if (option == 3)
            {
                journal.ReadFromFile();
            }
            else if (option == 4)
            {
                journal.WriteToFile();
            }
            else
            {
                Console.WriteLine("Goodbye");
                option = 5;
            }
        }
    }

    static int Menu()
    {
        int option = 0;
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string answer = Console.ReadLine();
        option = int.Parse(answer);
        return option;
    }
}