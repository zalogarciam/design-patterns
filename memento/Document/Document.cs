public class Document
{
    public string Content { get; set; }
    public string FontName { get; set; }
    public int FontSize { get; set; }

    public DocumentState CreateState()
    {
        return new DocumentState(Content, FontName, FontSize);
    }

    public void Restore(DocumentState state)
    {
        Content = state.Content;
        FontName = state.FontName;
        FontSize = state.FontSize;
    }

    public void ShowDocument()
    {
        Console.WriteLine("Content: " + Content);
        Console.WriteLine("Font Name: " + FontName);
        Console.WriteLine("Font Size: " + FontSize);
    }
}