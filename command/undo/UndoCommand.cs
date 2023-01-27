public class UndoCommand : ICommand
{
    private HistoryCommand History;

    public UndoCommand(HistoryCommand history)
    {
        History = history;
    }

    public void Execute()
    {
        if (History.Size() > 0)
            History.Pop().Unexecute();
    }
}