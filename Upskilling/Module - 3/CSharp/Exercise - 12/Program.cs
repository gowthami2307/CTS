using System;

class Product
{
    public string Name { get; set; } = string.Empty;

    private double price;

    public double Price
    {
        get => price;
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative.");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new()
        {
            Name = "Laptop",
            Price = 50000
        };

        Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine($"Price: {p.Price}");

        p.Price = -1000;

        Console.WriteLine($"Final Price: {p.Price}");
    }
}