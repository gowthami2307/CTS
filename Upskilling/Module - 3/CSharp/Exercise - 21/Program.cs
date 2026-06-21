using System;

class Program
{
    static void DisplayInfo(object obj)
    {
        if (obj is int number)
        {
            Console.WriteLine($"Integer: {number}");
        }
        else if (obj is string text)
        {
            Console.WriteLine($"String: {text}");
        }

        string result = obj switch
        {
            int => "This is an integer.",
            string => "This is a string.",
            double => "This is a double.",
            _ => "Unknown type."
        };

        Console.WriteLine(result);
    }

    static void Main()
    {
        DisplayInfo(100);
        DisplayInfo("Hello");
        DisplayInfo(99.99);
    }
}