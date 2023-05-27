
public class FactSegment : ISegment
{
    public void execute(IEditingOperation operation)
    {
        operation.Apply(this);
    }
}
