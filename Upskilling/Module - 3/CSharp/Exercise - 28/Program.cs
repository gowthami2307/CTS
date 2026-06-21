using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        using TextWriterTraceListener listener =
            new("log.txt");

        Trace.Listeners.Add(listener);

        Trace.WriteLine("Application Started");
        Trace.WriteLine("Logging Information");

        Trace.Flush();

        Console.WriteLine("Logs written to log.txt");
    }
}