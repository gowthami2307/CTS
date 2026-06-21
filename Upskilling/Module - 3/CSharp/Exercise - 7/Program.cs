using System;

class Program
{
    // Method with two integers
    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    // Method with three doubles
    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        int total1 = CalculateTotal(10, 20);
        Console.WriteLine("Total of two integers: " + total1);

        double total2 = CalculateTotal(10.5, 20.3, 30.2);
        Console.WriteLine("Total of three doubles: " + total2);
    }
}