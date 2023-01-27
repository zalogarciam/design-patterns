public class BoldCommand : IUndoableCommand
{
    private string PreviousContent;
    private HtmlDocument Document;
    private HistoryCommand History;

    public BoldCommand(HtmlDocument document, HistoryCommand history)
    {
        Document = document;
        History = history;
    }

    public void Execute()
    {
        PreviousContent = Document.Content;
        Document.MakeBold();
        History.Push(this);
    }

    public void Unexecute()
    {
        Document.Content = PreviousContent;
    }
}