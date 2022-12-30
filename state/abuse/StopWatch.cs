public class StopWatch
{
    private State CurrentState = new StoppedState(new StopWatch());
    public void click()
    {
        CurrentState.click();

        // if (isRunning)
        // {
        //     isRunning = false;
        //     Console.WriteLine("Stopped");
        // }
        // else 
        // {
        //     isRunning = true;
        //     Console.WriteLine("Running");
        // }

    }
}