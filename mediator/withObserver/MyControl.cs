public abstract class MyControl
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
            Console.WriteLine("Test");
            observer.Handle();
        }

    }
}