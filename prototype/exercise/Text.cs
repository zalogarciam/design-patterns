public class Text : IIComponent {
    private string content;

    public Text(string content) {
        this.content = content;
    }

    public string getContent() {
        return content;
    } 

      public IIComponent Clone()
    {
        IIComponent text = new Text(content);
        return text;
    } 
}
