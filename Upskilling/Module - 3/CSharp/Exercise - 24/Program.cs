using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
}

class Program
{
    static void Main()
    {
        User user = new()
        {
            Name = "Reddy",
            Age = 22,
            Email = "reddy@gmail.com"
        };

        string json = JsonSerializer.Serialize(user);

        File.WriteAllText("user.json", json);

        string data = File.ReadAllText("user.json");

        User? loadedUser = JsonSerializer.Deserialize<User>(data);

        if (loadedUser is not null)
        {
            Console.WriteLine($"Name: {loadedUser.Name}");
            Console.WriteLine($"Age: {loadedUser.Age}");
            Console.WriteLine($"Email: {loadedUser.Email}");
        }
    }
}