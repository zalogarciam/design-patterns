public class DbContext
{
    private Dictionary<int, Producto> updatedObjects = new Dictionary<int, Producto>();

    public Producto getProduct(int id)
    {
        // Automatically generate SQL statements
        // to read the product with the given ID.
        Console.WriteLine("SELECT * FROM products WHERE product_id = {0} \n", id);

        // Simulate reading a product object from a database.
        var product = new ProductProxy(id, this);
        product.setName("Product 1");

        return product;
    }

    public void saveChanges()
    {
        // Automatically generate SQL statements
        // to update the database.
        foreach (var updatedObject in updatedObjects.Values)
            Console.WriteLine("UPDATE products SET name = {0} WHERE product_id = {1} \n", updatedObject.getName(), updatedObject.getId());

        updatedObjects.Clear();
    }

    public void markAsChanged(Producto product)
    {
        updatedObjects[product.getId()] = product;
    }

}