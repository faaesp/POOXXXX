using System;

namespace P2UpdateClasses;

public class BankAccount
{
    private static int s_nextAccountNumber;

    public int AccountNumber { get; }
    public double Balance { get; private set; }
    public static double InterestRate { get; private set; }
    public string AccountType { get; set; } = "Checking";
    public string CustomerId { get; }

    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0;
    }

    public BankAccount(string customerIdNumber)
    {
        AccountNumber = s_nextAccountNumber++;
        CustomerId = customerIdNumber;
    }

    public BankAccount(string customerIdNumber, double balance, string accountType)
    {
        AccountNumber = s_nextAccountNumber++;
        CustomerId = customerIdNumber;
        Balance = balance;
        AccountType = accountType;
    }
}