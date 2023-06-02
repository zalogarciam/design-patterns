public class CaramelAdapter : Caramel, IIFilter
{
    // That is why ... composition over inheritance
    public void Apply(Image image)
    {
        Init();
        Render(image);
    }
}