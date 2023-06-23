public class Scheduler
{
    private Calendar calendar;
    public Scheduler()
    {
        calendar = createCalendar();
    }
    public void schedule(Event e)
    {
        var today = new DateTime();
        calendar.addEvent(e, today);
    }

    protected virtual Calendar createCalendar()
    {
        return new GregorianCalendar();
    }
}
