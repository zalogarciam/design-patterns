public class HtmlDocument 
{
    public string Content { get; set; }

    public HtmlDocument(string content)
    {
        Content = content;
    }

    public void MakeBold()
    {
        Content = "<b>" + Content + "</b>";
    }
}