using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = new()
        {
            Name = "Reddy",
            PhoneNumber = "9876543210"
        };

        Console.WriteLine(contact?.Name);

        contact = null;

        Console.WriteLine(contact?.Name ?? "Contact not available");
    }
}