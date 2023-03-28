public class ArticuleDialogBox : DialogBox
{
    private ListBox articlesListBox;
    private TextBoxUI titleTextBox;
    private ButtonUI saveButton;

    public ArticuleDialogBox()
    {
        articlesListBox = new ListBox(this);
        titleTextBox = new TextBoxUI(this);
        saveButton = new ButtonUI(this);
    }

    public void SimulateUserInteraction()
    {
        // articlesListBox.setSelection("Article 1");
        titleTextBox.setContent(string.Empty);
        // articlesListBox.setSelection("Article 2");
        Console.WriteLine("TextBox: " + titleTextBox.getContent());
        Console.WriteLine("Button: " + saveButton.getEnabled());
    }
    public override void changed(GUIControl control)
    {
        if (control == articlesListBox) ArticleSelected();
        else if (control == titleTextBox) TitleChanged();
    }

    private void TitleChanged()
    {
        var content = titleTextBox.getContent();
        var isEmpty = string.IsNullOrEmpty(content);
    }

    private void ArticleSelected()
    {
        titleTextBox.setContent(articlesListBox.getSelection());
        saveButton.setEnabled(true);
    }
}