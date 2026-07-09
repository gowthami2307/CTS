
// LAB - 4

/*
using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

// Create Categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };
var clothing = new Category { Name = "Clothing" };
var furniture = new Category { Name = "Furniture" };
var books = new Category { Name = "Books" };
var sports = new Category { Name = "Sports" };
var toys = new Category { Name = "Toys" };
var beauty = new Category { Name = "Beauty" };
var stationery = new Category { Name = "Stationery" };
var appliances = new Category { Name = "Home Appliances" };

// Add Categories
await context.Categories.AddRangeAsync(
    electronics,
    groceries,
    clothing,
    furniture,
    books,
    sports,
    toys,
    beauty,
    stationery,
    appliances
);

// Create Products
var products = new List<Product>
{
    new Product { Name = "Laptop", Price = 75000, Category = electronics },
    new Product { Name = "Rice Bag", Price = 1200, Category = groceries },
    new Product { Name = "T-Shirt", Price = 799, Category = clothing },
    new Product { Name = "Office Chair", Price = 5500, Category = furniture },
    new Product { Name = "C# Programming Book", Price = 950, Category = books },
    new Product { Name = "Cricket Bat", Price = 2500, Category = sports },
    new Product { Name = "Remote Control Car", Price = 1800, Category = toys },
    new Product { Name = "Face Wash", Price = 299, Category = beauty },
    new Product { Name = "Notebook", Price = 120, Category = stationery },
    new Product { Name = "Microwave Oven", Price = 8500, Category = appliances }
};

// Add Products
await context.Products.AddRangeAsync(products);

// Save Changes
await context.SaveChangesAsync();

Console.WriteLine("10 Categories and 10 Products inserted successfully!");


*/


// LAB - 5


/* using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Retrieve all products
Console.WriteLine("===== All Products =====");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id}. {p.Name} - ₹{p.Price}");
}

// Find Product by ID
Console.WriteLine("\n===== Find Product By ID =====");

var product = await context.Products.FindAsync(1);

if (product != null)
{
    Console.WriteLine($"Found: {product.Name}");
}
else
{
    Console.WriteLine("Product not found.");
}

// First product with Price > 50000
Console.WriteLine("\n===== Expensive Product =====");

var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);

if (expensive != null)
{
    Console.WriteLine($"Expensive: {expensive.Name}");
}
else
{
    Console.WriteLine("No expensive product found.");
}*/


//LAB - 6


/*
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// ---------------- UPDATE ----------------
var product = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    product.Price = 70000;

    await context.SaveChangesAsync();

    Console.WriteLine("Laptop price updated successfully!");
}
else
{
    Console.WriteLine("Laptop not found.");
}

// ---------------- DELETE ----------------
var toDelete = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (toDelete != null)
{
    context.Products.Remove(toDelete);

    await context.SaveChangesAsync();

    Console.WriteLine("Rice Bag deleted successfully!");
}
else
{
    Console.WriteLine("Rice Bag not found.");
}*/


// LAB -7 



using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// ---------------- Filter and Sort ----------------
Console.WriteLine("===== Products with Price > 1000 =====");

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

foreach (var product in filtered)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

// ---------------- DTO Projection ----------------
Console.WriteLine("\n===== Product DTOs =====");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var item in productDTOs)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}