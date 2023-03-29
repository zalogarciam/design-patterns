public class MyArticuleDialogBox
{
    private MyListBox articlesListBox;
    private MyTextBox titleTextBox;
    private MyButton saveButton;

    public MyArticuleDialogBox()
    {
        articlesListBox = new MyListBox();
        titleTextBox = new MyTextBox();
        saveButton = new MyButton();

        articlesListBox.AddEventHandler(new MyListBoxConcrete(this));
        titleTextBox.AddEventHandler(new MyListBoxConcrete(this));
        saveButton.AddEventHandler(new MyListBoxConcrete(this));
    }

    public class MyListBoxConcrete : IEventHandler
    {
        private MyArticuleDialogBox myArticuleDialogBox;

        public MyListBoxConcrete(MyArticuleDialogBox myArticuleDialogBox)
        {
            this.myArticuleDialogBox = myArticuleDialogBox;
        }

        void IEventHandler.Handle() => myArticuleDialogBox.ArticleSelected();
    }

    public class MyTextBoxConcrete : IEventHandler
    {
        private MyArticuleDialogBox myArticuleDialogBox;

        public MyTextBoxConcrete(MyArticuleDialogBox myArticuleDialogBox)
        {
            this.myArticuleDialogBox = myArticuleDialogBox;
        }

        void IEventHandler.Handle() => myArticuleDialogBox.TitleChanged();
    }

    public class MySaveButtonConcrete : IEventHandler
    {
        private MyArticuleDialogBox myArticuleDialogBox;

        public MySaveButtonConcrete(MyArticuleDialogBox myArticuleDialogBox)
        {
            this.myArticuleDialogBox = myArticuleDialogBox;
        }

        void IEventHandler.Handle() => myArticuleDialogBox.ArticleSelected();
    }


    public void SimulateUserInteraction()
    {
        // articlesListBox.setSelection("Article 1");
        titleTextBox.setContent(string.Empty);
        // articlesListBox.setSelection("Article 2");
        // Console.WriteLine("TextBox: " + titleTextBox.getContent());
        // Console.WriteLine("Button: " + saveButton.getEnabled());
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