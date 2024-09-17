namespace tests;

public class ShapeTests
{
    private void CheckShape(IShape shape, double result)
    {
        Assert.AreEqual(shape.GetArea(), result);
    }

    [Test]
    public void CircleTest()
    {
        var circle = new Circle(1);
        CheckShape(circle, Math.PI);
    }

    [Test]
    public void TriangleTest1()
    {
        var side1 = 3;
        var side2 = 4;
        var side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);
        CheckShape(triangle, 6);

        triangle = new Triangle(side3, side2, side1);
        CheckShape(triangle, 6);

        triangle = new Triangle(side2, side3, side1);
        CheckShape(triangle, 6);
    }

    [Test]
    public void TriangleTest2()
    {
        var side1 = 6;
        var side2 = 5;
        var side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);
        CheckShape(triangle, 12);

        triangle = new Triangle(side3, side2, side1);
        CheckShape(triangle, 12);

        triangle = new Triangle(side2, side3, side1);
        CheckShape(triangle, 12);
    }

    [Test]
    public void TriangleTest3()
    {
        var side1 = 2;
        var side2 = 1;
        var side3 = 1;
        
        Assert.Throws<WrongTriangleExaption>(() => new Triangle(side1, side2, side3));
    }
}