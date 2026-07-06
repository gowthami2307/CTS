using System;

namespace ECommerceSearch
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public string Category;

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        // Linear Search
        static Product LinearSearch(Product[] products, int id)
        {
            foreach (Product p in products)
            {
                if (p.ProductId == id)
                    return p;
            }
            return null;
        }

        // Binary Search
        static Product BinarySearch(Product[] products, int id)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (products[mid].ProductId == id)
                    return products[mid];

                if (products[mid].ProductId < id)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
            };

            Console.Write("Enter Product ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            Product result1 = LinearSearch(products, searchId);

            Console.WriteLine("\nUsing Linear Search:");

            if (result1 != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("ID: " + result1.ProductId);
                Console.WriteLine("Name: " + result1.ProductName);
                Console.WriteLine("Category: " + result1.Category);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Product result2 = BinarySearch(products, searchId);

            Console.WriteLine("\nUsing Binary Search:");

            if (result2 != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("ID: " + result2.ProductId);
                Console.WriteLine("Name: " + result2.ProductName);
                Console.WriteLine("Category: " + result2.Category);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.ReadLine();
        }
    }
}