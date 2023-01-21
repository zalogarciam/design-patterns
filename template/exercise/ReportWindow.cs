public class ReportWindow : Window
{
    protected override void OnClosed()
    {
        Console.WriteLine("On Closed");
    }

    protected override void OnClosing()
    {
        Console.WriteLine("On Closing");
    }
}