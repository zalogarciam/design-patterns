public class GmailProvider : IEmailProvider
{
    private GmailClient GmailClient;

    public GmailProvider(GmailClient gmailClient)
    {
        GmailClient = gmailClient;
    }

    public void downloadEmails()
    {
        GmailClient.connect();
        GmailClient.getEmails();
        GmailClient.disconnect();
    }
}