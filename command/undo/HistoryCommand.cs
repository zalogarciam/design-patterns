public class HistoryCommand
{
    private Stack<IUndoableCommand> commands = new Stack<IUndoableCommand>();
    public void Push(IUndoableCommand command)
    {
        commands.Push(command);
    }

    public IUndoableCommand Pop()
    {
        return commands.Pop();
    }

    public int Size()
    {
        return commands.Count;
    }
}