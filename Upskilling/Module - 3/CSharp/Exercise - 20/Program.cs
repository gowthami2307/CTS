using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new()
        {
            new() { OrderId = 1, CustomerName = "Reddy", TotalAmount = 500 },
            new() { OrderId = 2, CustomerName = "Kumar", TotalAmount = 1500 },
            new() { OrderId = 3, CustomerName = "Sai", TotalAmount = 2500 }
        };

        var result = orders
            .Where(order => order.TotalAmount > 1000)
            .Select(order => new
            {
                order.OrderId,
                order.CustomerName
            });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.OrderId} {item.CustomerName}");
        }
    }
}