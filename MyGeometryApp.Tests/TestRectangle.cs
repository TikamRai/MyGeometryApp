using Xunit;
using MyGeometryApp.Lib;

namespace MyGeometryApp.Tests;

public class TestRectangle
{
    [Fact]
    public void TestCalculateArea()
    {
        var rectangle = new Rectangle(4, 5);
        var result = rectangle.CalculateArea();
        Assert.Equal(20, result);
    }

    [Fact]
    public void TestCalculatePerimeter()
    {
        var rectangle = new Rectangle(4, 5);
        var result = rectangle.CalculatePerimeter();
        Assert.Equal(18, result);
    }
}