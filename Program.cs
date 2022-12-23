
// User user = new User("John Smith");
// user.SayHello();

// TaxCalculator calculator = GetCalculator();
// calculator.CalculateTax();

// static TaxCalculator GetCalculator()
// {
//     return new TaxCalculator2022();
// }

var account = new Account();
account.Deposit(10);
account.Withdraw(5);
Console.WriteLine(account.GetBalance());