public class Subject 
{
    private List<IObserver> Observers = new List<IObserver>();
    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in Observers)
            observer.Update();
    }
}