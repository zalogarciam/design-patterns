public class CaramelFilter : IIFilter
{
    private Caramel Caramel;

    public CaramelFilter(Caramel caramel)
    {
        Caramel = caramel;
    }

    public void Apply(Image image)
    {
        Caramel.Init();
        Caramel.Render(image);
    }
}