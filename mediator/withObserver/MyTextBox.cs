public class MyTextBox : MyControl
{
    private string Content;

    public string getContent()
    {
        return Content;
    }

    public void setContent(string content)
    {
        this.Content = content;
        NotifyEventHandlers();
    }
}