public class Group
{
    private List<Object> Objects = new List<Object>();
    public void Add(Object shape)
    {
        Objects.Add(shape);
    }

    public void Render()
    {
        foreach (var obj in Objects)
        {
            if (obj.GetType() == typeof(Shape))
                ((Shape)obj).Render();
            else
                ((Group)obj).Render();
        }
    }
}