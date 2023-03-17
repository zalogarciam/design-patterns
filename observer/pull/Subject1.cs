public class Subject1<T>
{
    private List<IObserver1<T>> Observers = new List<IObserver1<T>>();
    public void AddObserver(IObserver1<T> observer)
    {
        Observers.Add(observer);
    }
    public void RemoveObserver(IObserver1<T> observer)
    {
        Observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in Observers)
            observer.Update();
    }
}