public class ButtonUI : GUIControl
{
    private bool IsEnabled;

    public bool getEnabled()
    {
        return IsEnabled;
    }

    public void setEnabled(bool enable)
    {
        this.IsEnabled = enable;
    }
}