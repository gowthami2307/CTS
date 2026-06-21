using System;

class Car
{
    public string Make;
    public string Model;
    public int Year;

    // Default Constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // Parameterized Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Camry", 2024);

        car1.Display();
        car2.Display();
    }
}