// Coupling: how much a class is decoupled or depends on another class. Interfaces helps

// User user = new User("John Smith");
// user.SayHello();

// Interfaces: a contract that specifies the capabilities that a class should provide

// TaxCalculator calculator = GetCalculator();
// calculator.CalculateTax();

// static TaxCalculator GetCalculator()
// {
//     return new TaxCalculator2022();
// }

// Encapsulation: do not allow other classes like the main class to change the state of an object directly

// var account = new Account();
// // account.balance = -1;
// account.Deposit(10);
// account.Withdraw(5);
// Console.WriteLine(account.GetBalance());

// Abstraction: Reduce complexity by hiding unnecessary details

// var mailService = new Mail();
// mailService.SendEmail(); // Only this method insteado of 4

// Inheritance: is a a mecanism that allows us to reuse code across different classes

// TextBox
// Button
// CheckBox

// enable()
// focus()
// setPosition()

// var textBox = new TextBox();
// textBox.Enable();

// Polymorphism: Many Forms - hability of an object of take on many forms.

DrawUIControl(new TextBox());
DrawUIControl(new CheckBox());

static void DrawUIControl(UIControl control)
{
    control.Draw();
}