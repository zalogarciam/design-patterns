public class DataSource : Subject
{
    private int n;

    public int N
    {
        get { return n; }
        set
        {
            n = N;
            NotifyObservers();
        }
    }
}
