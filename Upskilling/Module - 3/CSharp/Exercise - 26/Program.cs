using System;
using System.Threading;

class Program
{
    private static int counter = 0;
    private static readonly object lockObj = new();

    static void Increment()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        Thread t1 = new(Increment);
        Thread t2 = new(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Counter = {counter}");
    }
}