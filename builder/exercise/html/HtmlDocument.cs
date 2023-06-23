using System.Text;

public class HtmlDoc
{
    private List<HtmlElement> elements = new List<HtmlElement>();

    public void add(HtmlElement element)
    {
        elements.Add(element);
    }

    public String copy()
    {
        var builder = new StringBuilder();
        builder.Append("<html>");
        foreach (HtmlElement element in elements)
            builder.Append(element.copy());

        builder.Append("</html>");
        return builder.ToString();
    }
}
