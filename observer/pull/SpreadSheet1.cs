public class SpreadSheet1<T> : IObserver1<T>
{
    private DataSource1<T> DataSource;
    public SpreadSheet1(DataSource1<T> dataSource)
    {
        DataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine("Spreadsheet updated " + DataSource.GetN());
    }
}