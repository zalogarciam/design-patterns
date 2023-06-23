public class HtmlBuilder : IDocumentBuilder
{
    private HtmlDoc document = new HtmlDoc();

    public void addText(Txt text)
    {
        document.add(new HtmlParagraph(text.getContent()));
    }

    public void addImage(Img image)
    {
        document.add(new HtmlImage(image.getSource()));
    }

    public String getResult()
    {
        return document.copy();
    }
}