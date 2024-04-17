using Xunit;
using MyGeometryApp.Lib;

namespace MyGeometryApp.Tests;

public class TestTriangle
{
    [Fact]
    public void TestCalculateArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var result = triangle.CalculateArea();
        Assert.Equal(6, result);
    }

    [Fact]
    public void TestCalculatePerimeter()
    {
        var triangle = new Triangle(3, 4, 5);
        var result = triangle.CalculatePerimeter();
        Assert.Equal(12, result);
    }
}