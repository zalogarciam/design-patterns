public class DemoBuilder
{
    public static void show()
    {
        // var document = new Doc();
        // document.add(new Txt("Hello World"));
        // document.add(new Img("pic1.jpg"));

        // document.export(ExportFormat.HTML, "export.html");

        // // Only writes the text elements to the file
        // document.export(ExportFormat.TEXT, "export.txt");

        var doc = new Doc();
        doc.add(new Txt("Hello World"));
        doc.add(new Img("pic1.jpg"));

        doc.export(new HtmlBuilder(), "export.html");

        // Only writes the text elements to the file
        doc.export(new TxtBuilder(), "export.txt");
    }
}
