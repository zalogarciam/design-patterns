public class ButtonUI : GUIControl
{
    private bool IsEnabled;

    public ButtonUI(DialogBox owner) : base(owner)
    {
    }

    public bool getEnabled()
    {
        return IsEnabled;
    }

    public void setEnabled(bool enable)
    {
        this.IsEnabled = enable;
        Owner.changed(this);
    }
}