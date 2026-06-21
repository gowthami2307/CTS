using System;

class Program
{
    static void Increment(ref int num)
    {
        num++;
    }

    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    static void Display(in int num)
    {
        Console.WriteLine("Value received using in: " + num);
    }

    static void Main(string[] args)
    {
        int a = 5;
        Console.WriteLine("Before ref: " + a);
        Increment(ref a);
        Console.WriteLine("After ref: " + a);

        int b, c;
        GetValues(out b, out c);
        Console.WriteLine($"Out values: {b}, {c}");

        int d = 100;
        Display(in d);
    }
}