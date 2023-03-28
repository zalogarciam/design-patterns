public class ListBox : GUIControl
{
    private string Selection;

    public string getSelection(){
        return Selection;
    }

    public void setSelection(string selection)
    {
        this.Selection = selection
    }  
}