public class Library
{

    private Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();
    public void Add(Ebook ebook)
    {
        ebooks.Add(ebook.FileName, ebook);
    }

    public void OpenEbook(string fileName)
    {
        ebooks[fileName].Show();
    }
}