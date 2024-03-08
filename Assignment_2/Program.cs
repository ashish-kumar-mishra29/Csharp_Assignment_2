// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name;
    public double Price;
    public int Quantity;
    public string Type;

    public Product(string name, double price, int quantity, string type)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Type = type;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("lettuce", 10.5, 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30, 30, "Marrow"),
            new Product("cauliflower", 10, 25, "Cruciferous"),
            new Product("zucchini", 20.5, 50, "Marrow"),
            new Product("yam", 30, 50, "Root"),
            new Product("spinach", 10, 100, "Leafy green"),
            new Product("broccoli", 20.2, 75, "Cruciferous"),
            new Product("garlic", 30, 20, "Leafy green"),
            new Product("silverbeet", 10, 50, "Marrow")
        };

        // Print total number of products
        Console.WriteLine("\nList of all products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}, {product.Price} RS, {product.Quantity}, {product.Type}");
        }
        Console.WriteLine("Total number of products: " + products.Count);

        // Add a new product
        products.Add(new Product("Potato", 10, 50, "Root"));

        // Print list of all products and total number of products
        Console.WriteLine("\nList of all products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}, {product.Price} RS, {product.Quantity}, {product.Type}");
        }
        Console.WriteLine("Total number of products: " + products.Count);

        // Print products of type Leafy green
        Console.WriteLine("\nProducts of type Leafy green:");
        var leafyGreens = products.Where(p => p.Type == "Leafy green");
        foreach (var product in leafyGreens)
        {
            Console.WriteLine($"{product.Name}, {product.Price} RS, {product.Quantity}, {product.Type}");
        }

        // Remove garlic from the list
        products.RemoveAll(p => p.Name == "garlic");
        Console.WriteLine("\nTotal number of products after removing garlic: " + products.Count);

        // Add 50 cabbages to the inventory
        var cabbage = products.FirstOrDefault(p => p.Name == "cabbage");
        if (cabbage != null)
        {
            cabbage.Quantity += 50;
            Console.WriteLine("Final quantity of cabbage in the inventory: " + cabbage.Quantity);
        }

        // Calculate total amount for purchasing 1kg lettuce, 2 kg zucchini, 1 kg broccoli
        double totalAmount = 1 * products.First(p => p.Name == "lettuce").Price + 2 * products.First(p => p.Name == "zucchini").Price + 1 * products.First(p => p.Name == "broccoli").Price;
        Console.WriteLine("\nTotal amount for purchasing 1kg lettuce, 2 kg zucchini, 1 kg broccoli: " + totalAmount + " RS");
    }
}

