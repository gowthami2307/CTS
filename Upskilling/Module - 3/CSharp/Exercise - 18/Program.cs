using System;

class Student
{
    public required int Id { get; set; }

    public required string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new()
        {
            Id = 1,
            Name = "Reddy"
        };

        Console.WriteLine($"{student.Id} {student.Name}");
    }
}