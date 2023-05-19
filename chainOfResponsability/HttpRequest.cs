public class HttpRequest
{
    public HttpRequest(string user, string password)
    {
        this.Username = user;
        this.Password = password;
    }

    public String? Username { get; set; }
    public String? Password { get; set; }

}