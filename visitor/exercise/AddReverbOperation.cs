public class AddReverbOperation : IEditingOperation
{
    public void Apply(ISegment segment)
    {
        Console.WriteLine("Add reverb");
    }
}