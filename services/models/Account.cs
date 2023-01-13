public class Account
{
    private float balance;

    public void Deposit(float amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(float amount)
    {
        if (amount > 0)
            balance -= amount;
    }

    public float GetBalance()
    {
        return balance;
    }

    public void SetBalance(float balance)
    {
        if (balance > 0)
            this.balance = balance;
    }
}