public class AnchorNode : IHtmlNode
{
    public void execute(IOperation operation)
    {
        operation.Apply(this);
    }

}