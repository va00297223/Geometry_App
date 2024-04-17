using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryApp_Library;
class Program
{
    static async Task Main(string[] args)
    {
        var fm = new Dictionary<string, string> {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(fm)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var f_manager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

        // Check if Square feature is enabled
        if (await f_manager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Square feature is accessible.!");
            
            Console.WriteLine();
            Console.WriteLine("Enter a length of the Square: ");
            if (double.TryParse(Console.ReadLine(), out double length))
            {
                var square = new Square(length);
                Console.WriteLine();
                Console.WriteLine($"Area of Square: {square.CalculateArea()}");
                Console.WriteLine($"Perimeter of Square: {square.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Square feature is not accessible.!");
        }

        // Check if Rectangle feature is enabled
        if (await f_manager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Rectangle feature is accessible.!");

            Console.WriteLine();
            Console.WriteLine("Enter the length: ");
            if (double.TryParse(Console.ReadLine(), out double l))
            {
                Console.WriteLine();
                Console.WriteLine("Enter the width: ");
                if (double.TryParse(Console.ReadLine(), out double w))
                {                  
                    var rectangle = new Rectangle(l, w);

                    Console.WriteLine();
                    Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
                    Console.WriteLine($"Perimeter of Rectangle: {rectangle.CalculatePerimeter()}");
                }
                else
                {
                    Console.WriteLine("Invalid input for width.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for length.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Rectangle feature is not accessible.!");
        }

        // Check if Triangle feature is enabled
        if (await f_manager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Triangle feature is accessible.!");
            Console.WriteLine();
            Console.WriteLine("Enter the length of side 1: ");
            if (double.TryParse(Console.ReadLine(), out double s1))
            {
                Console.WriteLine("Enter the length of side 2: ");
                if (double.TryParse(Console.ReadLine(), out double s2))
                {
                    Console.WriteLine("Enter the length of side 3: ");
                    if (double.TryParse(Console.ReadLine(), out double s3))
                    {
                        var triangle = new Triangle(s1, s2, s3);

                        Console.WriteLine();
                        Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}");
                        Console.WriteLine($"Perimeter of Triangle: {triangle.CalculatePerimeter()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for side 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for side 2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for side 1.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Triangle feature is not accessible.!");
        }


    }
}
