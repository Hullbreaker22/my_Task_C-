using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        //Accounts
        var accounts = new List<Account>();
        accounts.Add(new Account());
        accounts.Add(new Account("Larry"));
        accounts.Add(new Account("Moe", 2000));
        accounts.Add(new Account("Curly", 5000));

        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);

        //Savings
        var savAccounts = new List<Account>();
        savAccounts.Add(new Saving_account());
        savAccounts.Add(new Saving_account("Superman"));
        savAccounts.Add(new Saving_account("Batman", 2000));
        savAccounts.Add(new Saving_account("Wonderwoman", 5000, 5.0));

        AccountUtil.Deposit(savAccounts, 1000);
        AccountUtil.Withdraw(savAccounts, 2000);



        //// Checking
        var checAccounts = new List<Account>();
        checAccounts.Add(new Checking_account());
        checAccounts.Add(new Checking_account("Larry2"));
        checAccounts.Add(new Checking_account("Moe2", 2000));
        checAccounts.Add(new Checking_account("Curly2", 5000));

        AccountUtil.Deposit(checAccounts, 1000);
        AccountUtil.Withdraw(checAccounts, 2000);
        AccountUtil.Withdraw(checAccounts, 2000);



        // Trust
        var trustAccounts = new List<Account>();
        trustAccounts.Add(new Trust_Account());
        trustAccounts.Add(new Trust_Account("Superman2"));
        trustAccounts.Add(new Trust_Account("Batman2", 2000));
        trustAccounts.Add(new Trust_Account("Wonderwoman2", 5000, 5.0));

        AccountUtil.Deposit(trustAccounts, 1000);
        AccountUtil.Deposit(trustAccounts, 6000);
        AccountUtil.Withdraw(trustAccounts, 2000);
        AccountUtil.Withdraw(trustAccounts, 3000);
        AccountUtil.Withdraw(trustAccounts, 500);
        AccountUtil.Withdraw(trustAccounts, 500);
        AccountUtil.Withdraw(trustAccounts, 500);
        AccountUtil.Withdraw(trustAccounts, 500);
        AccountUtil.Withdraw(trustAccounts, 500);

        Console.WriteLine();
    }
}

internal static class AccountUtil
{
    
    public static void Deposit(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Depositing to Accounts =================================");
        foreach (var acc in accounts)
        {
            if (acc.Deposite(amount))
                Console.WriteLine($"Deposited {amount} to {acc}");
            else
                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        }
    }

    public static void Withdraw(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
        foreach (var acc in accounts)
        {
            if (acc.Withdraw(amount))
                Console.WriteLine($"Withdrew {amount} from {acc}");
            else
                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
        }
    }

   
    
    
}