public class PointIconFactory
{
    private Dictionary<PointType, PointIcon> dictionary = new Dictionary<PointType, PointIcon>();

    public PointIcon GetPointIcon(PointType type)
    {
        if (!dictionary.ContainsKey(type))
        {
            var icon = new PointIcon(type, null);
            dictionary.Add(type, icon);
        }
        return dictionary[type];
    }
}