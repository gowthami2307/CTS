using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new()
        {
            "Apple",
            "Banana",
            "Mango"
        };

        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> students = new()
        {
            { 1, "Reddy" },
            { 2, "Kumar" },
            { 3, "Sai" }
        };

        Console.WriteLine();

        Console.WriteLine("Dictionary:");

        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}