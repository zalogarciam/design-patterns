public class ContactForm
{
    public void render(Theme theme)
    {
        if (theme == Theme.ANT)
        {
            new AntTextBox().render();
            new AntButton().render();
        }
        if (theme == Theme.MATERIAL)
        {
            new MaterialTextBox().render();
            new MaterialButton().render();
        }
    }
}