using System.Collections;

public class HtmlDocumento
{
    private List<IHtmlNode> Nodes = new List<IHtmlNode>();

    public void Add(IHtmlNode node)
    {
        Nodes.Add(node);
    }

    public void Execute(IOperation operation){
        foreach(var node in Nodes){
            node.execute(operation);
        }
    }
}