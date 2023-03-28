public class ListBox : GUIControl
{
    private string Selection;

    public ListBox(DialogBox owner) : base(owner)
    {
    }

    public string getSelection()
    {
        return Selection;
    }

    public void setSelection(string selection)
    {
        this.Selection = selection;
        Owner.changed(this);
    }
}