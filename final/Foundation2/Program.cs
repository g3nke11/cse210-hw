using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("253 Dirt Rd.", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product prod1 = new Product("Bed Frame", "BES1253", 153.95, 1);
        Product prod2 = new Product("Carmel Tie", "CLT567", 13.95, 2);
        Product prod3 = new Product("40\" Flatscreen television", "CST596", 463.95, 3);
        Order order1 = new Order(customer1, [prod1, prod2, prod3]);

        Console.WriteLine("First Order: \n");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"${order1.TotalPrice():F2}");
        Console.WriteLine();

        Address address2 = new Address("22 Stone Lane", "Zhuzhou", "Hunan", "China");
        Customer customer2 = new Customer("Fang Wen", address2);
        Product prod4 = new Product("Bed Frame", "BES1253", 153.95, 3);
        Product prod5 = new Product("Carmel Tie", "CLT567", 13.95, 5);
        Product prod6 = new Product("40\" Flatscreen television", "CST596", 463.95, 1);
        Order order2 = new Order(customer2, [prod4, prod5, prod6]);

        Console.WriteLine("Second Orer: \n");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"${order2.TotalPrice():F2}");
    }
}