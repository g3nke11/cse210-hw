using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ListingActivity listingA = new ListingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        MindfulnessActivity mind = new MindfulnessActivity();
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t 1. Start breathing activity");
            Console.WriteLine("\t 2. Start reflection activity");
            Console.WriteLine("\t 3. Start listing activity");
            Console.WriteLine("\t 4. Start mindfulness activity");
            Console.WriteLine("\t 5. Quit");
            Console.Write("Select a choice from the menu: ");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (select == 1)
            {
                breath.Breath();
            }
            else if (select == 2)
            {
                reflect.Reflect();
            }
            else if (select == 3)
            {
                listingA.Listing();
            }
            else if (select == 4)
            {
                mind.Mind();
            }
            else if (select == 5)
            {
                break;
            }
        }
    }
}