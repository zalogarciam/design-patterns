public class ProductCollection
{
    private List<Product> products = new List<Product>();

    public void add(Product product)
    {
        products.Add(product);
    }
}