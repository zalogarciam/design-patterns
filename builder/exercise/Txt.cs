public class Txt : IElement
{
    private String content;

    public Txt(String content)
    {
        this.content = content;
    }

    public String getContent()
    {
        return content;
    }
}
