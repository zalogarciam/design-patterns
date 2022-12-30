public class DocumentState 
{
    public string Content { get; set; }
    public string FontName { get; set; }
    public int FontSize { get; set; }

    public DocumentState(string Content, string FontName, int FontSize)
    {
        this.Content = Content;
        this.FontName = FontName;
        this.FontSize = FontSize;
    }
}