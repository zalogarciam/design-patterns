// Memento
public class EditorState
{
    public string Content { get; set; }
    public EditorState(string Content)
    {
        this.Content = Content;
    }
}