using System;

class Program
{
    static void Main()
    {
        string[] cities =
        {
            "Hyderabad",
            "Bangalore",
            "Chennai",
            "Mumbai",
            "Delhi"
        };

        Console.WriteLine("=== Using for Loop ===");

        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine(cities[i]);
        }

        Console.WriteLine();

        Console.WriteLine("=== Using foreach Loop ===");

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine();

        Console.WriteLine("=== Using while Loop ===");

        int index = 0;

        while (index < cities.Length)
        {
            Console.WriteLine(cities[index]);
            index++;
        }

        Console.WriteLine();

        Console.WriteLine("=== Using do-while Loop ===");

        index = 0;

        do
        {
            Console.WriteLine(cities[index]);
            index++;
        }
        while (index < cities.Length);
    }
}