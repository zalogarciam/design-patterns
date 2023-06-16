public class Circle : IComponente
{
    public Circle(int radius)
    {
        Radius = radius;
    }
    public int Radius { get; set; }
    public void Render()
    {
        System.Console.WriteLine("Rendering a circle");
    }

    public IComponente Clone()
    {
        IComponente newCircle = new Circle(Radius);
        return newCircle;
    }
}