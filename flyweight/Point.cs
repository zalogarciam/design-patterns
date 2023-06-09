public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public PointIcon Icon { get; set; }
    public Point(int x, int y, PointIcon pointIcon)
    {
        this.x = x;
        this.y = y;
        Icon = pointIcon;
    }

    public void Draw()
    {
        System.Console.WriteLine($"{Icon.GetType()} at {x} {y}");
    }
}