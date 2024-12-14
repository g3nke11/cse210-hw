using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("395 Now st", "Nowhere", "California", "USA");
        Lecture event1 = new Lecture("Birthday Parties and the effects", "A discussion of birthday parties and their effects on the recepient.", "03 Oct 2022", "3:00 pm", address1, "Grace", 120);
        Console.WriteLine(event1.StandardDetail());
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine();

        Address address2 = new Address("126 Then rd", "Somethen", "Idaho", "USA");
        Reception event2 = new Reception("Birthday Party", "The celebration of the Snow's birth", "06 Nov 1999", "4:30 pm", address2);
        Console.WriteLine(event2.StandardDetail());
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine();

        Address address3 = new Address("321 Never Dr", "Nowhen", "Washington", "USA");
        OutdoorGathering event3 = new OutdoorGathering("The Welding's Wedding Reception", "The celebration of the the Welding's wedding", "15 Apr 2020", "9:00 am", address3, "Cloudy");
        Console.WriteLine(event3.StandardDetail());
        Console.WriteLine(event3.FullDetails());
        Console.WriteLine(event3.ShortDescription());
    }
}