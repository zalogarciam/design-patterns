public class ProductCollection
{
    private List<Product> Products = new List<Product>();

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public void Remove(Product product)
    {
        Products.Remove(product);
    }

    public IIterator<Product> CreateIterator()
    {
        return new ProductListIterator(this);
    }

    public class ProductListIterator : IIterator<Product>
    {
        public ProductCollection ProductCollection;
        private int Index;
        public ProductListIterator(ProductCollection productCollection)
        {
            ProductCollection = productCollection;
        }

        public Product Current()
        {
            return ProductCollection.Products[Index];
        }

        public bool HasNext()
        {
            return Index < ProductCollection.Products.Count;
        }

        public void Next()
        {
            Index++;
        }
    }
}