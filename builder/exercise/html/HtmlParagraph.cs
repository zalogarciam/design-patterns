public class HtmlParagraph : HtmlElement
{
    private String text;

    public HtmlParagraph(String text)
    {
        this.text = text;
    }

    public override String copy()
    {
        return String.Format("<p>{0}</p>", text);
    }
}
