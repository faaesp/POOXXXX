using System;
using P2UpdateClasses;

BankCustomer customer1 = new BankCustomer("Tim", "Shao");
BankCustomer customer2 = new BankCustomer("Lisa", "Shao");
BankCustomer customer3 = new BankCustomer("Sandy", "Zoeng");

Console.WriteLine(customer1.DisplayCustomerInfo());
Console.WriteLine(customer2.DisplayCustomerInfo());
Console.WriteLine(customer3.DisplayCustomerInfo());

// Utilisation des méthodes de BankCustomer
customer1.UpdateName("Thomas", "Shao");
Console.WriteLine($"Updated customer 1: {customer1.ReturnFullName()}");

// Utilisation des méthodes d'extension de BankCustomer
Console.WriteLine(customer1.GreetCustomer());
Console.WriteLine($"Valid ID: {customer1.IsValidCustomerId()}");

// Création et opérations sur les comptes
BankAccount account1 = new BankAccount(customer1.CustomerId);
BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

Console.WriteLine("\n--- Opérations bancaires ---");
account1.Deposit(500);
Console.WriteLine($"Après dépôt sur Account 1 : {account1.DisplayAccountInfo()}");

account2.Withdraw(200);
Console.WriteLine($"Après retrait sur Account 2 : {account2.DisplayAccountInfo()}");

account3.Transfer(account1, 300);
Console.WriteLine($"Après transfert de Account 3 vers Account 1 :");
Console.WriteLine(account3.DisplayAccountInfo());
Console.WriteLine(account1.DisplayAccountInfo());

// Utilisation des méthodes d'extension de BankAccount
Console.WriteLine($"\nAccount 1 peut retirer 1000 ? {account1.CanWithdraw(1000)}");
Console.WriteLine($"Account 1 à découvert ? {account1.IsOverdrawn()}");