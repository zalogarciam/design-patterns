
// User user = new User("John Smith");
// user.SayHello();

TaxCalculator calculator = GetCalculator();
calculator.CalculateTax();

static TaxCalculator GetCalculator()
{
    return new TaxCalculator2022();
}