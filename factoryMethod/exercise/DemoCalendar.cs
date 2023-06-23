public class DemoCalendar
{
    public static void show()
    {
        var scheduler = new Scheduler();
        scheduler.schedule(new Event());

        // Arabian scheduler using the Arabian calendar
        var arabianScheduler = new ArabianScheduler();
        arabianScheduler.schedule(new Event());
    }
}