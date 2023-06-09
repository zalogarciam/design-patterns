public class Cell
{
    private readonly int row;
    private readonly int column;
    private String content;
    private String fontFamily;
    private int fontSize;
    private bool isBold { get; set; }

    public Cell(int row, int column)
    {
        this.row = row;
        this.column = column;
    }

    public String getContent()
    {
        return content;
    }

    public void setContent(String content)
    {
        this.content = content;
    }

    public String getFontFamily()
    {
        return fontFamily;
    }

    public void setFontFamily(String fontFamily)
    {
        this.fontFamily = fontFamily;
    }

    public int getFontSize()
    {
        return fontSize;
    }

    public void setFontSize(int fontSize)
    {
        this.fontSize = fontSize;
    }


    public void render()
    {
        System.Console.WriteLine("({0}, {1}): {2} [{3}]\n", row, column, content, fontFamily);
    }
}