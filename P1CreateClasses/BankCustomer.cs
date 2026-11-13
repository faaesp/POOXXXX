using System;

namespace P1CreateClasses;

public class BankCustomer
{
    private static int s_nextCustomerId;
    public readonly string CustomerId;
    public string FirstName = "Tim";
    public string LastName = "Shao";

    static BankCustomer()
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(10000000, 20000000);
    }

    public BankCustomer()
    {
        this.CustomerId = (s_nextCustomerId++).ToString("D10");
    }

    public BankCustomer(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.CustomerId = (s_nextCustomerId++).ToString("D10");
    }
}