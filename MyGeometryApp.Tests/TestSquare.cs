using Xunit;
using MyGeometryApp.Lib;

namespace MyGeometryApp.Tests;

public class TestSquare
{
    [Fact]
    public void TestCalculateArea()
    {
        var square = new Square(4);
        var result = square.CalculateArea();
        Assert.Equal(16, result);
    }

    [Fact]
    public void TestCalculatePerimeter()
    {
        var square = new Square(6);
        var result = square.CalculatePerimeter();
        Assert.Equal(24, result);
    }
}