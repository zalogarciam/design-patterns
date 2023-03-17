public class SpreadSheet<T> : IObserver<T>
{
    public void Update(T n)
    {
        Console.WriteLine("Spreadsheet updated: " + n);
    }
}