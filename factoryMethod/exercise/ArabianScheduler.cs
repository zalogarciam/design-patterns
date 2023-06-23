
public class ArabianScheduler : Scheduler
{
    protected override Calendar createCalendar()
    {
        return new ArabianCalendar();
    }

}