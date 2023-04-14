public class CButton : CUIControl
{
    private bool isEnabled;
    public bool getEnabled()
    {
        return isEnabled;
    }

    public void setEnabled(bool enabled)
    {
        isEnabled = enabled;
        NotifyEventHandlers();
    }
}
