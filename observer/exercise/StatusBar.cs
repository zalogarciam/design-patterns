public class StatusBar<T> : IObserver<StockModel>
{
    public List<StockModel> stockList = new List<StockModel>();
    public void Update(StockModel stock)
    {
        Console.WriteLine("Status bar updated ... " + stock.Price);
    }
}