using System;

class Student(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Display()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age  : {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new("Rahul", 21);

        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        student.Display();
    }
}