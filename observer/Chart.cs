public class Chart<T> : IObserver<T>
{
    public void Update(T n)
    {
        Console.WriteLine("Chart updated: " + n);
    }
}