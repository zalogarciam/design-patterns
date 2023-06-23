public class SharpViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context)
    {
        return "View Sharp";
    }
}