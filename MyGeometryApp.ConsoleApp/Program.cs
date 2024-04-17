using System;
using MyGeometryApp.Lib;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Threading.Tasks;

namespace MyGeometryApp.ConsoleApp;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            {"FeatureManagement:Square", "true"},
            {"FeatureManagement:Rectangle", "false"},
            {"FeatureManagement:Triagnle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Enter the side length (in centimeter) of the Square: ");
            double sideLength = double.Parse(Console.ReadLine() ?? "0");
            Square square = new Square(sideLength);
            Console.WriteLine($"Area of the Square: {square.CalculateArea()} sq. cm");
            Console.WriteLine($"Perimeter of the Square: {square.CalculatePerimeter()}  cm");
         }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Enter the length (in centimeter) of the Rectagnel: ");
            double length = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the breadth (in centimeter) of the Rectangle: ");
            double breadth = double.Parse(Console.ReadLine() ?? "0");
            Rectangle rectangle = new Rectangle(length, breadth);
            Console.WriteLine($"Area of the Rectangle: {rectangle.CalculateArea()} sq. cm");
            Console.WriteLine($"Perimeter of the Rectangle: {rectangle.CalculatePerimeter()} cm");
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Enter the side A (in centimeter) of the Triangle: ");
            double sideA = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the side B (in centimeter) of the Triangle: ");
            double sideB = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the side C (in centimeter) of the Triangle: ");
            double sideC = double.Parse(Console.ReadLine() ?? "0");
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine($"Area of the Triangle: {triangle.CalculateArea()} sq. cm");
            Console.WriteLine($"Perimeter of the Triangle: {triangle.CalculatePerimeter()} cm");
        }
    }
}