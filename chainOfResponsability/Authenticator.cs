public class Authenticator
{
    public bool Authenticate(HttpRequest request)
    {
        var isValid = (request.Username == "Admin" && request.Password == "1234");
        Console.WriteLine("Authentication");
        return isValid;
    }
}