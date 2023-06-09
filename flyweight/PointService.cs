public class PointService{
    public List<Point> GetPoints(){
        var list = new List<Point>();
        list.Add(new Point(1, 2, PointType.CAFE, null));
        return list;
    }
}