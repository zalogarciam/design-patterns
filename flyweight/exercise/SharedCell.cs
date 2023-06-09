public class SharedCell
{
    private String fontFamily;
    private int fontSize;

    public SharedCell(string fontFamily, int fontSize, bool isBold)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.isBold = isBold;
    }

    public bool isBold { get; set; }

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


}