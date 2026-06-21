using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        File.WriteAllText("sample.txt", "Hello FileStream");

        using FileStream fs = new(
            "sample.txt",
            FileMode.Open,
            FileAccess.Read);

        using StreamReader reader = new(fs);

        Console.WriteLine(reader.ReadToEnd());

        using MemoryStream ms = new();

        byte[] data = Encoding.UTF8.GetBytes("Hello MemoryStream");

        ms.Write(data, 0, data.Length);

        Console.WriteLine($"Bytes Written: {ms.Length}");
    }
}