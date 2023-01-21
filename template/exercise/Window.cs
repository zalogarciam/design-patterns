public abstract class Window
{
    public void Close()
    {
        OnClosing();
        Console.WriteLine("Removing the window from the screen");
        OnClosed();
    }

    protected abstract void OnClosed();
    protected abstract void OnClosing();
}
