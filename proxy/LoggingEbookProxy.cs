public class LoggingEbookProxy : IEBook
{
    public string FileName { get; set; }
    private Ebook Ebook;
    public LoggingEbookProxy(string fileName)
    {
        FileName = fileName;
    }
    public void Show()
    {
        if (Ebook == null)
            Ebook = new Ebook(FileName);

        System.Console.WriteLine("Logging");
        Ebook.Show();
    }

    public string GetFileName()
    {
        return FileName;
    }
}