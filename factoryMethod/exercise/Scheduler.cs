public class Scheduler {
    private Calendar calendar = new Calendar();

    public void schedule(Event e) {
        var today = new DateTime();
        calendar.addEvent(e, today);
    }
}
