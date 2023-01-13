public class BrowserHistory
{
    private List<string> Urls = new List<string>();
    public List<string> GetUrls
    {
        get
        {
            return Urls;
        }
    }
    public void Push(string url)
    {
        Urls.Add(url);
    }

    public void Pop()
    {
        Urls.RemoveAt(Urls.Count - 1);
    }

}