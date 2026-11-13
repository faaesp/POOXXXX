using System;
using P3ImplementClasses;

BankCustomer customer1 = new BankCustomer("Tim", "Shao");
Console.WriteLine(customer1.DisplayCustomerInfo());
Console.WriteLine(customer1.GreetCustomer());

BankAccount account1 = new BankAccount(customer1.CustomerId, 1000, "Savings");
account1.ApplyInterest(2);
Console.WriteLine(account1.DisplayAccountInfo());
Console.WriteLine($"Numéro de compte valide ? {AccountCalculations.ValidateAccountNumber(account1.AccountNumber)}");