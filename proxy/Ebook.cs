public class Ebook {
    public string FileName { get; set; }

    public Ebook(string fileName)
    {
        FileName = fileName;
        Load();
    }

    private void Load(){
        System.Console.WriteLine("Loading the ebook... " + FileName);
    }

    public void Show(){
        System.Console.WriteLine("Showing the ebook... " + FileName);
    }
}