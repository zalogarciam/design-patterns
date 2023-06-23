public class ContactForm
{
    public void render(IWidgetFactory factory)
    {
        factory.createTextBox().render();
        factory.createButton().render();
    }
}