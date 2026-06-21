using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Using var
        var number = 100;
        var message = "Hello C#";
        var pi = 3.14;

        Console.WriteLine("Using var");
        Console.WriteLine($"Number  : {number}");
        Console.WriteLine($"Message : {message}");
        Console.WriteLine($"PI      : {pi}");

        Console.WriteLine();

        // Using target-typed new()
        Student student = new()
        {
            Name = "Rahul",
            Age = 21
        };

        Console.WriteLine("Using new()");
        Console.WriteLine($"Name : {student.Name}");
        Console.WriteLine($"Age  : {student.Age}");

        Console.WriteLine();

        List<string> cities = new()
        {
            "Hyderabad",
            "Bangalore",
            "Chennai"
        };

        Console.WriteLine("Cities");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }
}