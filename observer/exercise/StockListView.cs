public class StockListView<T> : IObserver<StockModel>
{
    public List<StockModel> stockList = new List<StockModel>();
    public void Update(StockModel stock)
    {
        Console.WriteLine("Stock List View updated ... " + stock.Price);
    }
}