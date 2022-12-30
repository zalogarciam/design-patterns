public class StopWatch
{
    private bool isRunning;
    public void click()
    {
        if (isRunning)
        {
            isRunning = false;
            Console.WriteLine("Stopped");
        }
        else 
        {
            isRunning = true;
            Console.WriteLine("Running");
        }

    }
}