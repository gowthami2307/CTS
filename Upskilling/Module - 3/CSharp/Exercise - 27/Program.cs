using System;
using System.Threading;

class Program
{
    private static readonly object lock1 = new();
    private static readonly object lock2 = new();

    static void Method1()
    {
        if (Monitor.TryEnter(lock1, 1000))
        {
            try
            {
                Thread.Sleep(100);

                if (Monitor.TryEnter(lock2, 1000))
                {
                    try
                    {
                        Console.WriteLine("Method1 acquired both locks");
                    }
                    finally
                    {
                        Monitor.Exit(lock2);
                    }
                }
            }
            finally
            {
                Monitor.Exit(lock1);
            }
        }
    }

    static void Method2()
    {
        if (Monitor.TryEnter(lock2, 1000))
        {
            try
            {
                Thread.Sleep(100);

                if (Monitor.TryEnter(lock1, 1000))
                {
                    try
                    {
                        Console.WriteLine("Method2 acquired both locks");
                    }
                    finally
                    {
                        Monitor.Exit(lock1);
                    }
                }
            }
            finally
            {
                Monitor.Exit(lock2);
            }
        }
    }

    static void Main()
    {
        Thread t1 = new(Method1);
        Thread t2 = new(Method2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
}