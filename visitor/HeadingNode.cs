public class HeadingNode : IHtmlNode
{
    public void execute(IOperation operation)
    {
        operation.Apply(this);
    }
}