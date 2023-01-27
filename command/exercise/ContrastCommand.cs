public class ContrastCommand : IUndoableCommand
{
    private float Contrast;
    private float prevContrast;
    private VideoEditor VideoEditor;

    private HistoryCommand History;

    public ContrastCommand(float contrast, VideoEditor videoEditor, HistoryCommand history)
    {
        VideoEditor = videoEditor;
        History = history;
        this.Contrast = contrast;
    }

    public void Execute()
    {
        VideoEditor.SetContrast(Contrast);
    }

    public void Unexecute()
    {
        VideoEditor.SetContrast(prevContrast);
    }
}