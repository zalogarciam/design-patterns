// Originator
public class Editor
{
    public string Content { get; set; }

    public EditorState CreateState()
    {
        return new EditorState(Content);
    }

    public void Restore(EditorState editorState)
    {
        Content = editorState.Content;
    }
}

