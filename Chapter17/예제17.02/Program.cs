
class Program
{
    static void Main(string[] args)
    {
        Point p = new(5, 6);
    }
}

public record Point
{
    public int X;
    public int Y;

    public Point(int x, int y) { X = x; Y = y; }
}