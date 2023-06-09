public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    private PointType type;

    private byte[] icon;

    public Point(int x, int y, PointType type, byte[] icon)
    {
        this.x = x;
        this.y = y;
        this.type = type;
        this.icon = icon;
    }

    public void Draw()
    {
        System.Console.WriteLine($"{type} at {x} {y}");
    }
}