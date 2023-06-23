public class HtmlImage : HtmlElement
{
    private String source;

    public HtmlImage(String source)
    {
        this.source = source;
    }

    public override String copy()
    {
        return String.Format("<img src=\"{0}\" />", source);
    }
}
