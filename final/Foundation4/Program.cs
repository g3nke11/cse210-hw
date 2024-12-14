using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(30, "03 Nov 2022", (float)3.0);
        Console.WriteLine(run1.GetSummary());
        Cycling cycle1 = new Cycling(15, "03 Nov 2022", (float)12.0);
        Console.WriteLine(cycle1.GetSummary());
        Swimming swim1 = new Swimming(10, "03 Nov 2022", (float) 3.5);
        Console.WriteLine(swim1.GetSummary());

    }
}