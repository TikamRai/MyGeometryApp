using MyGeometryApp.Lib.Interfaces;

namespace MyGeometryApp.Lib;

public class Rectangle : IShape
{
    public double Length { get; }
    public double Breadth { get; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public double CalculateArea()
    {
        return Length * Breadth;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Breadth);
    }
}