using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(30, "03 Nov 2022", (float)3.0);
        Console.WriteLine(run1.GetSummary());

    }
}