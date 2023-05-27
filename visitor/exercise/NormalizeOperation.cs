public class NormalizeOperation : IEditingOperation
{
    public void Apply(ISegment segment)
    {
        Console.WriteLine("Normalize");
    }
}