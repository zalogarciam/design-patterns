public class LabelCommand : IUndoableCommand
{
    private string Text;
    private string PreviousText;

    private VideoEditor VideoEditor;

    private HistoryCommand History;

    public LabelCommand(string text, VideoEditor videoEditor, HistoryCommand history)
    {
        VideoEditor = videoEditor;
        History = history;
        this.Text = text;
    }

    public void Execute()
    {
        PreviousText = VideoEditor.GetText();
        VideoEditor.SetText(Text);
        History.Push(this);
    }

    public void Unexecute()
    {
        VideoEditor.RemoveText();
    }
}