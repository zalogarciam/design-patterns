public class ProductsController : Controller
{
    public void ListProducts()
    {
        // Get products from a database
        Dictionary<string, object> context = new Dictionary<string, object>();
        // context.put(products)
        Render("products.html", context, new MatchaViewEngine());
    }
}