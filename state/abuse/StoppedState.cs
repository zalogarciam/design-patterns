public class StoppedState : State
{
    private StopWatch stopWatch;
    public StoppedState(StopWatch stopWatch)
    {
        this.stopWatch = stopWatch;
    }
    public void click()
    {
        Console.WriteLine("Stopped");
    }
}