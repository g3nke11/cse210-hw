using System;

class Program
{
    static void Main(string[] args)
    {
        int input_num = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (input_num != 0)
        {
        Console.Write("Enter number: ");
        string answer = Console.ReadLine();
        input_num = int.Parse(answer);
        if (input_num != 0)
        {
        numbers.Add(input_num);
        }
        }

        int sum_num = 0;
        int largest_num = 0;
        int smallest_pos_num = 999999999;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum_num += numbers[i];
            if (largest_num < numbers[i])
            {
                largest_num = numbers[i];
            }
            if (smallest_pos_num > numbers[i] && numbers[i] > 0)
            {
                smallest_pos_num = numbers[i];
            }
        }
        float avg_num = ((float)sum_num) / numbers.Count;
        numbers.Sort();
        
        Console.WriteLine($"The sum is: {sum_num}");
        Console.WriteLine($"The average is: {avg_num}");
        Console.WriteLine($"The largest number is: {largest_num}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}