using System.Text;

public class TxtBuilder : IDocumentBuilder
{
    private StringBuilder document = new StringBuilder();

  
    public void addImage(Img image)
    {
        document.Append(image.getSource());
    }

    public void addText(Txt text)
    {
        document.Append(text.getContent());
    }

    public string getResult()
    {
        return document.ToString();
    }

}