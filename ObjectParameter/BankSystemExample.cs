namespace BankSystem
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }
    }

    class Bank
    {
        public void Deposit(BankAccount account, decimal amount)
        {
            account.Balance += amount;
            Console.WriteLine($"{amount:C} deposited to {account.AccountHolder}'s account.");
        }

        public void Withdraw(BankAccount account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn from {account.AccountHolder}'s account.");
            }
            else
            {
                Console.WriteLine($"Insufficient balance for {account.AccountHolder}.");
            }
        }

        public void DisplayBalance(BankAccount account)
        {
            Console.WriteLine($"Balance for {account.AccountHolder}: {account.Balance:C}");
        }
    }
}