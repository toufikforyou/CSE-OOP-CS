public class BankAccount
{
    // A static variable that counts the number of accounts created
    public static int AccountCount = 0;

    // A readonly variable that represents the account number, which is assigned only once
    public readonly int AccountNumber;

    // A const variable representing the bank's name (final and static by nature)
    public const string BankName = "Global Trust Bank";

    // A static readonly variable representing the bank's interest rate, which is set at runtime
    public static readonly double InterestRate;

    // Instance variable representing the balance
    private double balance;

    // Static constructor to initialize the static readonly variable
    static BankAccount()
    {
        InterestRate = 3.5; // 3.5% interest rate
    }

    // Constructor to initialize the readonly variable and instance-specific values
    public BankAccount(double initialBalance)
    {
        AccountNumber = ++AccountCount;
        balance = initialBalance;
    }

    // Static method to display the total number of accounts
    public static void DisplayAccountCount()
    {
        Console.WriteLine("Total Bank Accounts: " + AccountCount);
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: $" + amount);
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Bank: {BankName}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: ${balance}");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}