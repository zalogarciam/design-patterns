public class HighLightOperation : IOperation
{
    public void Apply(HeadingNode heading)
    {
        Console.WriteLine("Highlighting heading");
    }

    public void Apply(AnchorNode anchor)
    {
        Console.WriteLine("Highlighting anchor");
    }
}