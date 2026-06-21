using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        int Factorial(int x)
        {
            if (x <= 1)
                return 1;
            return x * Factorial(x - 1);
        }

        return Factorial(n);
    }

    static void Main(string[] args)
    {
        int number = 5;
        int result = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} = {result}");
    }
}