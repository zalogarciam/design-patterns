public class DataSource1<T> : Subject1<T>
{
    private T n;

    public void SetN(T n)
    {
        this.n = n;
        NotifyObservers();
    }

    public T GetN()
    {
        return n;
    }
}
