public class EBookProxy : IEBook
{
    public string FileName { get; set; }
    private Ebook Ebook;
    public EBookProxy(string fileName)
    {
        FileName = fileName;
    }
    public void Show()
    {
        if (Ebook == null)
            Ebook = new Ebook(FileName);
        Ebook.Show();
    }

    public string GetFileName()
    {
        return FileName;
    }
}