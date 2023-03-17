public class LabelCommand : AbstractUndoableCommand
{
	private string Text;
	private string PreviousText;

	private VideoEditor VideoEditor;

	private HistoryCommand History;

	public LabelCommand(string text, VideoEditor videoEditor, HistoryCommand history) : base (videoEditor, history)
	{
		VideoEditor = videoEditor;
		History = history;
		this.Text = text;
	}

	protected override void doUnexecute()
	{
		VideoEditor.RemoveText();
	}

	protected override void doExecute()
	{
		VideoEditor.SetText(Text);
	}
}

