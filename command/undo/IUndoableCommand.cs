public interface IUndoableCommand : ICommand
{
    void Unexecute();
}