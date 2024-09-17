public class WrongTriangleExaption : System.Exception
{
    public WrongTriangleExaption() { }
    public WrongTriangleExaption(string message) : base(message) { }
    public WrongTriangleExaption(string message, System.Exception inner) : base(message, inner) { }
}