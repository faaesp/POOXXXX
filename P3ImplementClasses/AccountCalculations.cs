namespace P3ImplementClasses;

public static class AccountCalculations
{
    public static double CalculateCompoundInterest(double principal, double annualRate, double years)
    {
        return principal * Math.Pow(1 + annualRate, years) - principal;
    }

    public static bool ValidateAccountNumber(int accountNumber)
    {
        return accountNumber >= 10000000 && accountNumber <= 99999999;
    }

    public static double CalculateTransactionFee(double amount, double transactionRate, double maxFee)
    {
        double fee = amount * transactionRate;
        return Math.Min(fee, maxFee);
    }

    public static double CalculateOverdraftFee(double amountOverdrawn, double overdraftRate, double maxFee)
    {
        double fee = amountOverdrawn * overdraftRate;
        return Math.Min(fee, maxFee);
    }

    public static double ReturnCurrencyConvertedBalance(double balance, double exchangeRate)
    {
        return balance * exchangeRate;
    }
}