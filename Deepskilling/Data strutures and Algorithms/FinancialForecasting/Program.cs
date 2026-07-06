using System;

namespace FinancialForecasting
{
    class Program
    {
        // Recursive method to calculate future value
        static double FutureValue(double currentValue, double growthRate, int years)
        {
            // Base case
            if (years == 0)
                return currentValue;

            // Recursive case
            return FutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Current Value: ");
            double currentValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (in %): ");
            double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter Number of Years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = FutureValue(currentValue, growthRate, years);

            Console.WriteLine("\nFuture Value after " + years + " years = " + futureValue.ToString("F2"));

            Console.ReadLine();
        }
    }
}