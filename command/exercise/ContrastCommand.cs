public class ContrastCommand : AbstractUndoableCommand
{
    private float Contrast;
    private float PrevContrast;
    private VideoEditor VideoEditor;

    private HistoryCommand History;

    public ContrastCommand(float contrast, VideoEditor videoEditor, HistoryCommand history) : base(videoEditor, history)
    {
        VideoEditor = videoEditor;
        History = history;
        this.PrevContrast = videoEditor.GetContrast();
        this.Contrast = contrast;
    }

    protected override void doUnexecute()
    {
        VideoEditor.SetContrast(PrevContrast);
    }

    protected override void doExecute()
    {
        VideoEditor.SetContrast(Contrast);
    }
}