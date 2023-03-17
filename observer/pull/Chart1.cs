public class Chart1<T> : IObserver1<T>
{
    private DataSource1<T> DataSource;
    public Chart1(DataSource1<T> dataSource)
    {
        DataSource = dataSource;
    }
    public void Update()
    {
        Console.WriteLine("Chart updated: " + DataSource.GetN());
    }
}