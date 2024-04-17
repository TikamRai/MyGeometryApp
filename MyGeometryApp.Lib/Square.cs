using MyGeometryApp.Lib.Interfaces;

namespace MyGeometryApp.Lib;

public class Square : IShape
{
    public double SideLength { get; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * SideLength;
    }
}