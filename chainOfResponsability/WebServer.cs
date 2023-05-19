public class WebServer
{
    private Handler Handler;

    public WebServer(Handler handler)
    {
        Handler = handler;
    }

    public void Handle(HttpRequest request)
    {
        Handler.Handle(request);
    }
}