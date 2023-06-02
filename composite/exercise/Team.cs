
public class Team : IIncidentComponent
{
    private List<IIncidentComponent> resources = new List<IIncidentComponent>();

    public void add(IIncidentComponent resource)
    {
        resources.Add(resource);
    }

    public void deploy()
    {
        foreach (var resource in resources)
        {
            resource.deploy();
        }
    }
}
