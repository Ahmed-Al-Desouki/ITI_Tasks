using System;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static Product createProduct()
    {
        return new Product { Name = "Laptop", Price = 15000.99m };
    }

    public static void Main()
    {
        // Test createProduct
        var product = createProduct();
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");

        // Test StringExtensions
        string text = "Hello, world!";
        Console.WriteLine($"Word count: {text.WordCount()}"); // Should print 2
        Console.WriteLine($"Reversed: {text.Reverse()}"); // Should print "!dlrow ,olleH"

        // Test IntExtensions
        int num = 10;
        Console.WriteLine($"{num} is even: {num.IsEven()}"); // Should print true
        num = 7;
        Console.WriteLine($"{num} is even: {num.IsEven()}"); // Should print false

        // Test DateTimeExtensions
        DateTime birthDate = new DateTime(2000, 5, 15);
        int age = birthDate.CalculateAge();
        Console.WriteLine($"Age: {age}"); // Should print 25 (as of 2025-09-22)
    }
}

public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) return 0;
        return str.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static string Reverse(this string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthDate.Year;
        if (birthDate > today.AddYears(-age)) age--;
        return age;
    }
}