namespace tests;

public class TriangleTests
{
    [Test]
    public void Test1()
    {
        var side1 = 3;
        var side2 = 4;
        var side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);
        Assert.AreEqual(triangle.GetArea(), 6);

        triangle = new Triangle(side3, side2, side1);
        Assert.AreEqual(triangle.GetArea(), 6);

        triangle = new Triangle(side2, side3, side1);
        Assert.AreEqual(triangle.GetArea(), 6);
    }
}