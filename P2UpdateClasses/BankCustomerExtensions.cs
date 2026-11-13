namespace P2UpdateClasses;

public static class BankCustomerExtensions
{
    public static bool IsValidCustomerId(this BankCustomer customer)
    {
        return customer.CustomerId.Length == 10;
    }

    public static string GreetCustomer(this BankCustomer customer)
    {
        return $"Hello, {customer.ReturnFullName()}!";
    }
}