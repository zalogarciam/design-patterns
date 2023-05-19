public class WebServer
{

    public void Handle(HttpRequest request)
    {
        var authenticator = new Authenticator(); // Because of "new" this class is tighly coupled to this class.
        authenticator.Authenticate(request);
    }
}