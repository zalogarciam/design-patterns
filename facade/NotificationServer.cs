public class NotificationServer {
    public Connection Connect(String ipAddress)
    {
        return new Connection();
    }

    public AuthToken Authenticate(string appId, string key)
    {
        return new AuthToken();
    }

    public void Send(AuthToken authToken, Message message, string target)
    {
        System.Console.WriteLine("Sending a message");
    }
}