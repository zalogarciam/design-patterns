public class MyListBox : MyControl
{
    private string Selection;

    public string getSelection()
    {
        return Selection;
    }

    public void setSelection(string selection)
    {
        this.Selection = selection;
        NotifyEventHandlers();
    }
}