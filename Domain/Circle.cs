public class Circle : IShape
{
    public double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}