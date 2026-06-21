using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Value Type Example ===");

        int a = 10;
        int b = a;

        b = 20;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        Console.WriteLine();

        Console.WriteLine("=== Reference Type Example ===");

        Student s1 = new Student();
        s1.Name = "Rahul";

        Student s2 = s1;

        s2.Name = "Kiran";

        Console.WriteLine($"s1.Name = {s1.Name}");
        Console.WriteLine($"s2.Name = {s2.Name}");
    }
}

class Student
{
    public string Name="";
}