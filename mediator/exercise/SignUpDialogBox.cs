public class SignUpDialogBox
{
    private CTextBox usernameTextBox;
    private CTextBox passwordTextBox;
    private CCheckBox termsCheckBox;
    private CButton signUpButton;

    public SignUpDialogBox()
    {
        usernameTextBox = new CTextBox();
        passwordTextBox = new CTextBox();
        termsCheckBox = new CCheckBox();
        signUpButton = new CButton();

        usernameTextBox.AddEventHandler(new CTextBoxConcrete(this));
        passwordTextBox.AddEventHandler(new CTextBoxConcrete(this));
        termsCheckBox.AddEventHandler(new CCheckBoxConcrete(this));
        signUpButton.AddEventHandler(new CButtonConcrete(this));
    }


    public class CTextBoxConcrete : IEventHandler
    {
        private SignUpDialogBox signUpDialogBox;

        public CTextBoxConcrete(SignUpDialogBox signUpDialogBox)
        {
            this.signUpDialogBox = signUpDialogBox;
        }

        void IEventHandler.Handle() => signUpDialogBox.TextBoxChanged();
    }

    public class CCheckBoxConcrete : IEventHandler
    {
        private SignUpDialogBox signUpDialogBox;

        public CCheckBoxConcrete(SignUpDialogBox signUpDialogBox)
        {
            this.signUpDialogBox = signUpDialogBox;
        }

        void IEventHandler.Handle() => signUpDialogBox.CheckBoxChanged();
    }
    public class CButtonConcrete : IEventHandler
    {
        private SignUpDialogBox signUpDialogBox;

        public CButtonConcrete(SignUpDialogBox signUpDialogBox)
        {
            this.signUpDialogBox = signUpDialogBox;
        }

        void IEventHandler.Handle() => signUpDialogBox.ButtonChanged();
    }

    private void ButtonChanged()
    {
        Console.WriteLine("Button: " + signUpButton.getEnabled());
    }

    private void TextBoxChanged()
    {
        signUpButton.setEnabled(IsSignUpFormValid());
    }

    private void CheckBoxChanged()
    {
        signUpButton.setEnabled(IsSignUpFormValid());
    }

    private bool IsSignUpFormValid()
    {
        if (string.IsNullOrEmpty(usernameTextBox.getContent()) || string.IsNullOrEmpty(passwordTextBox.getContent()) || !termsCheckBox.getChecked())
            return false;
        return true;
    }


    public void SimulateUserInteraction()
    {
        usernameTextBox.setContent("zalogarciam");
        passwordTextBox.setContent("*******");
        termsCheckBox.setChecked(true);
        Console.WriteLine("TextBox: " + usernameTextBox.getContent());
        Console.WriteLine("TextBox: " + passwordTextBox.getContent());
        Console.WriteLine("CheckBox: " + termsCheckBox.getChecked());
        Console.WriteLine("Button: " + signUpButton.getEnabled());
    }

}