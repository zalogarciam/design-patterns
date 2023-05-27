public class PlainTextOperation : IOperation
{
    public void Apply(HeadingNode heading)
    {
        Console.WriteLine("Text heading");
    }

    public void Apply(AnchorNode anchor)
    {
        Console.WriteLine("Text anchor");
    }
}