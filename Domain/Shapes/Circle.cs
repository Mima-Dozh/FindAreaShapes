public class Circle : IShape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return 2 * Math.PI * _radius * _radius;
    }
}