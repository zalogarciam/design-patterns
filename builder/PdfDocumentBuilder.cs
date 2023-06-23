public class PdfDocumentBuilder : IPresentationBuilder
{
    private PdfDocument document = new PdfDocument();
    public void AddSlide(Slide slide)
    {
        document.AddPage(slide.Text);
    }

    internal PdfDocument getPdfDocument()
    {
        return document;
    }
}