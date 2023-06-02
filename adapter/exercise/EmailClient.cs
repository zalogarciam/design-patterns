
public class EmailClient
{
    private List<IEmailProvider> providers = new List<IEmailProvider>();

    public void addProvider(IEmailProvider provider)
    {
        providers.Add(provider);
    }

    public void downloadEmails()
    {
        foreach (var provider in providers)
            provider.downloadEmails();
    }
}
