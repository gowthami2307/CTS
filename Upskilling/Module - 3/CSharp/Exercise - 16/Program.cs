using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? person = null;

        string name = person?.Name ?? "Name not available";

        Console.WriteLine(name);

        person = new Person
        {
            Name = "Reddy"
        };

        Console.WriteLine(person?.Name ?? "Name not available");
    }
}