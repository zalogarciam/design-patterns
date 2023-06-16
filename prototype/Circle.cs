public class Circle : IComponente
{
    public int Radius { get; set; }
    public void Render()
    {
        System.Console.WriteLine("Rendering a circle");
    }

    public IComponent Clone()
    {
        Circle newCircle = new Circle();
        newCircle.Radius = source.Radius;
        return newCircle;
    }
}