// The purpose of this class is to make sure all undoable commands have
// a VideoEditor and a History. Plus, whenever a command is executed,
// it's pushed in the history. This way, we don't have to remember to
// store each individual command in the history.
public abstract class AbstractUndoableCommand : IUndoableCommand
{
    protected VideoEditor videoEditor;
    protected HistoryCommand history;

    public AbstractUndoableCommand(VideoEditor videoEditor, HistoryCommand history)
    {
        this.videoEditor = videoEditor;
        this.history = history;
    }

    public void Execute()
    {
         // Another application of the template method pattern. This method
        // is defining a template for executing commands.
        doExecute();
        history.Push(this);
    }

    public void Unexecute()
    {
        doUnexecute();
    }

    protected abstract void doExecute();
    protected abstract void doUnexecute();
}
