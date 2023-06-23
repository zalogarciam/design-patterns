public class MaterialWidgetFactory : IWidgetFactory
{
    public IButton createButton()
    {
        return new MaterialButton();
    }

    public ITextBox createTextBox()
    {
        return new MaterialTextBox();
    }
}