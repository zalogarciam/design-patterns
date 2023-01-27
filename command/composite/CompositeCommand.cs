public class CompositeCommand : ICommand
{
    private List<ICommand> commands = new List<ICommand>();

    public void Add(ICommand command)
    {
        commands.Add(command);
    }
    public void Execute()
    {
        foreach (ICommand command in commands)
            command.Execute();
    }
}