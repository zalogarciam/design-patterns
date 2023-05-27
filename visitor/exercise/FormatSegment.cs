
public class FormatSegment : ISegment
{
    public void execute(IEditingOperation operation)
    {
        operation.Apply(this);
    }
}
