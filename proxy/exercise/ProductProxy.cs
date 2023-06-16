public class ProductProxy : Producto
{
    private DbContext context;

    public ProductProxy(int id, DbContext context) : base(id)
    {
        this.context = context;
    }

    public void setName(string name)
    {
        base.setName(name);
        context.markAsChanged(this);
    }
    //   public ProductProxy(int id, DbContext context) {
    //     super(id);
    //     this.context = context;
    //   }

    //   public void setName(String name) {
    //     super.setName(name);

    //     context.markAsChanged(this);
    //   }
}
