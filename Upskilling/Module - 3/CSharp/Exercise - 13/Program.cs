using System;

public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public double Salary { get; init; }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new()
        {
            Id = 101,
            Name = "Reddy",
            Salary = 50000
        };

        Employee emp2 = emp1 with
        {
            Salary = 60000
        };

        Console.WriteLine("Original Record:");
        Console.WriteLine($"{emp1.Id} {emp1.Name} {emp1.Salary}");

        Console.WriteLine();

        Console.WriteLine("Modified Copy:");
        Console.WriteLine($"{emp2.Id} {emp2.Name} {emp2.Salary}");
    }
}