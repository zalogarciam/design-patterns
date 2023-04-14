public class CUIControl
{
    private List<IEventHandler> EventHandlers = new List<IEventHandler>();
    public void AddEventHandler(IEventHandler observer)
    {
        EventHandlers.Add(observer);
    }

    protected void NotifyEventHandlers()
    {
        foreach (var observer in EventHandlers)
        {
            observer.Handle();
        }

    }
}
