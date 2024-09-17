public class Triangle : IShape
{
    private List<double> _sides = new List<double>(new double[3]);

    public Triangle(double side1, double side2, double side3)
    {
        _sides[0] = side1;
        _sides[1] = side2;
        _sides[2] = side3;
        _sides = _sides.OrderBy(side => side).ToList();
    }

    private bool IsRightAngled()
    {
        return _sides[0] * _sides[0] + _sides[1] * _sides[1] == _sides[2] * _sides[2];
    }

    public double GetArea()
    {
        if (IsRightAngled())
        {
            return _sides[0] * _sides[1] / 2;
        }

        var halfPerimeter = (_sides[0] + _sides[1] + _sides[2]) / 2;
        return Math.Sqrt(halfPerimeter *
                        (halfPerimeter - _sides[0]) *
                        (halfPerimeter - _sides[1]) *
                        (halfPerimeter - _sides[2]));
    }
}