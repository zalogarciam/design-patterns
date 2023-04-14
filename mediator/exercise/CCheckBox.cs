
public class CCheckBox : CUIControl
{
    private bool isChecked;
    public bool getChecked()
    {
        return isChecked;
    }

    public void setChecked(bool check)
    {
        isChecked = check;
        NotifyEventHandlers();
    }
}
