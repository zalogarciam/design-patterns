using System.Collections;

public class HtmlDocumento
{
    private List<IHtmlNode> Nodes = new List<IHtmlNode>();

    public void Add(IHtmlNode node)
    {
        Nodes.Add(node);
    }

    public void HighLight()
    {
        foreach (var node in Nodes)
            node.HighLight();
    }
}