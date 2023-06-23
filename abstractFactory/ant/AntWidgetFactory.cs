public class AntWidgetFactory : IWidgetFactory
{
    public IButton createButton()
    {
        return new AntButton();
    }

    public ITextBox createTextBox()
    {
        return new AntTextBox();
    }
}