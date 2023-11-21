using System;

class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public string AccountHolderName { get; set; }
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }

    // Constructor
    public BankAccount(string accountHolderName)
    {
        // Generate a simple account number (you might want to implement a more sophisticated method)
        AccountNumber = GenerateAccountNumber();
        AccountHolderName = accountHolderName;
        Balance = 0;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please deposit an amount greater than zero.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    private string GenerateAccountNumber()
    {
        // This is a simple example; you might want to implement a more secure method for generating account numbers.
        return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of BankAccount
        BankAccount myAccount = new BankAccount("John Doe");

        // Print initial account details
        Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
        Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
        Console.WriteLine($"Initial Balance: {myAccount.Balance:C}");

        // Deposit some amount
        myAccount.Deposit(1000);

        // Withdraw some amount
        myAccount.Withdraw(500);

        // Print final account details
        Console.WriteLine($"Final Balance: {myAccount.Balance:C}");

        Console.ReadLine(); // Keep the console window open
    }
}
