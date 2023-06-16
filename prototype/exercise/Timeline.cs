using System.Collections.Generic;

public class Timeline
{
    private List<IIComponent> components = new List<IIComponent>();

    public void Add(IIComponent component)
    {
        components.Add(component);
    }
}
