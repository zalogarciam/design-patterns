public class Button {
    public string Label { get; set; }
    private ICommand Command { get; set; }

    public Button(ICommand command)
    {
        Command = command;
    }

    public void Click()
    {
        Command.Execute();
    }
}