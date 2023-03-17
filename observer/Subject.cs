public class Subject<T>
{
    private List<IObserver<T>> Observers = new List<IObserver<T>>();
    public void AddObserver(IObserver<T> observer)
    {
        Observers.Add(observer);
    }
    public void RemoveObserver(IObserver<T> observer)
    {
        Observers.Remove(observer);
    }
    public void NotifyObservers(T n)
    {
        foreach (var observer in Observers)
            observer.Update(n);
    }
}