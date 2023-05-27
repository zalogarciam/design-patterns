public class ReduceNoiseOperation : IEditingOperation
{
    public void Apply(ISegment segment)
    {
        Console.WriteLine("Reduce noise");
    }
}