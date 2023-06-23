public class Img : IElement
{
    private String source;

    public Img(string source)
    {
        this.source = source;
    }

    public String getSource()
    {
        return source;
    }
}
