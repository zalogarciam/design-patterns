public class Product
{
    private int Id;
    private String Name;

    public Product(int id, String name)
    {
        this.Id = id;
        this.Name = name;
    }

    public override String ToString()
    {
        return "Product{" +
                " Id=" + Id +
                ", Name='" + Name + '\'' +
                '}';
    }
}