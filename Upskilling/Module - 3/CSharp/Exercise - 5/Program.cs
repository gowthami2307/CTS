using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Marks (0 - 100): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int marks))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Marks must be between 0 and 100.");
            return;
        }

        string grade;

        if (marks >= 90)
        {
            grade = "A";
        }
        else if (marks >= 80)
        {
            grade = "B";
        }
        else if (marks >= 70)
        {
            grade = "C";
        }
        else if (marks >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Marks : {marks}");
        Console.WriteLine($"Grade : {grade}");
    }
}