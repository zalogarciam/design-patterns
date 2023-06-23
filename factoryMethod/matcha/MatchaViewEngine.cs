public class MatchaViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context)
    {
        return "View rendered by Matcha";
    }
}