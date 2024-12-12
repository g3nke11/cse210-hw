using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("395 Now st", "Nowhere", "California", "USA");
        Lecture event1 = new Lecture("Birthday Party", "The celebration of the Snow's birth", "03 Oct 2022", "3:00 pm", address1, "Grace", 120);
        Console.WriteLine(event1.StandardDetail());
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine(event1.ShortDescription());
    }
}