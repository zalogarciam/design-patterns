public class PointService 
{
    private PointIconFactory factory;

    public PointService(PointIconFactory factory)
    {
        this.factory = factory;
    }

    public List<Point> GetPoints(){

        var list = new List<Point>();
        list.Add(new Point(1, 2, factory.GetPointIcon(PointType.CAFE)));
        return list;
    }
}