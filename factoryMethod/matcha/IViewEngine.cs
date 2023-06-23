public interface IViewEngine
{
    string Render(string viewName, Dictionary<string, object> context);
}