public class Library
{

    private Dictionary<string, IEBook> ebooks = new Dictionary<string, IEBook>();
    public void Add(IEBook ebook)
    {
        ebooks.Add(ebook.GetFileName(), ebook);
    }

    public void OpenEbook(string fileName)
    {
        ebooks[fileName].Show();
    }
}