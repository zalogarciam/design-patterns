public class Mail
{
    public void SendEmail()
    {
        Connect(10); // Main class is not affected! Abstraction principle. We change the implemenation detail without affecting other classes in the ap
        Authenticate();
        Disconnect();
    }

    private void Connect(int timeout)
    {
        Console.WriteLine("Connecting");
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconnect");
    }

    private void Authenticate()
    {
        Console.WriteLine("Authentication");
    }

}