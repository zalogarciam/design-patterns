public interface IDocumentBuilder
{
    void addText(Txt text);
    void addImage(Img image);
    String getResult();
}
