public class Controller {
    public void Render(string viewName, Dictionary<string, object> context){
        var engine = CreateViewEngine();
        var html = engine.Render(viewName, context);
        System.Console.WriteLine(html);
    }

    protected virtual IViewEngine CreateViewEngine(){
        return new MatchaViewEngine();
    }
}