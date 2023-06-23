public class Controller {
    public void Render(string viewName, Dictionary<string, object> context, IViewEngine engine){
        var html = engine.Render(viewName, context);
        System.Console.WriteLine(html);
    }
}