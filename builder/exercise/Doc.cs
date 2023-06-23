using System.Text;

public class Doc {
    private List<IElement> elements = new List<IElement>();

    public void add(IElement element) {
        elements.Add(element);
    }

    public void export(ExportFormat format, String fileName) {
        String content = "";

        if (format == ExportFormat.HTML) {
            var document = new HtmlDoc();

            foreach (IElement element in elements) {
                // if (element instanceof Text) {
                //     var text = ((Text)element).getContent();
                //     document.add(new HtmlParagraph(text));
                // }
                // else if (element instanceof Image) {
                //     var source = ((Image)element).getSource();
                //     document.add(new HtmlImage(source));
                // }
            }

            content = document.toString();
        }
        else if (format == ExportFormat.TEXT) {
            var builder = new StringBuilder();

            foreach (IElement element in elements) {
                // if (element instanceof Text) {
                //     var text = ((Text)element).getContent();
                //     builder.append(text);
                // }
            }

            content = builder.ToString();
        }

        // var writer = new FileWriter(fileName);
        // writer.write(content);
        // writer.close();
    }
}
