public class Stock<T> : Subject<T>
{
    private T stock;
    public void SetStock(T stock)
    {
        this.stock = stock;
        NotifyObservers(stock);
    }
}

public class StockModel
{
    public double Price { get; set; }
    public string Symbol { get; set; }

    public StockModel(double price, string symbol)
    {
        Price = price;
        Symbol = symbol;
    }
}