public class TextBoxUI : GUIControl
{
    private string Content;

    public TextBoxUI(DialogBox owner) : base(owner)
    {
    }

    public string getContent()
    {
        return Content;
    }

    public void setContent(string content)
    {
        this.Content = content;
        Owner.changed(this);
    }
}