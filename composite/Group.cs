public class Group : IComponent
{
    private List<IComponent> Components = new List<IComponent>();
    public void Add(IComponent component)
    {
        Components.Add(component);
    }

    public void Move()
    {
        foreach (var component in Components)
        {
            component.Move();
        }
    }

    public void Render()
    {
        foreach (var component in Components)
        {
            component.Render();
        }
    }

}