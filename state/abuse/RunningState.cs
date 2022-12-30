public class RunningState : State
{
    private StopWatch stopWatch;
    public RunningState(StopWatch stopWatch)
    {
        this.stopWatch = stopWatch;
    }
    public void click()
    {
        Console.WriteLine("Running");
    }
}