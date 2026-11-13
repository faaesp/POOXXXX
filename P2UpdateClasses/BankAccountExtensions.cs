namespace P2UpdateClasses;

public static class BankAccountExtensions
{
    public static bool IsOverdrawn(this BankAccount account)
    {
        return account.Balance < 0;
    }

    public static bool CanWithdraw(this BankAccount account, double amount)
    {
        return account.Balance >= amount;
    }
}