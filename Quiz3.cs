using System;

namespace BankSystem
{
    // Base class
    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; protected set; }

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {HolderName}, Balance: {Balance:C}");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount:C} deposited. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public abstract void Withdraw(double amount);
    }

    // Savings Account
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string holderName, double balance, double interestRate)
            : base(accountNumber, holderName, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }

        public void AddInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest of {interest:C} added. New Balance: {Balance:C}");
        }
    }

    // Current Account
    class CurrentAccount : BankAccount
    {
        public double OverdraftLimit { get; set; }

        public CurrentAccount(string accountNumber, string holderName, double balance, double overdraftLimit)
            : base(accountNumber, holderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return;
            }

            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Withdrawal denied. Overdraft limit exceeded.");
            }
        }
    }

    // Test Program
    class Program
    {
        static void Main(string[] args)
        {
            // Test Savings Account
            SavingsAccount savings = new SavingsAccount("S001", "Alice", 1000.0, 5.0);
            savings.CheckBalance();
            savings.Deposit(500);
            savings.Withdraw(300);
            savings.AddInterest();

            Console.WriteLine();

            // Test Current Account
            CurrentAccount current = new CurrentAccount("C001", "Bob", 500.0, 1000.0);
            current.CheckBalance();
            current.Deposit(200);
            current.Withdraw(1000);
            current.Withdraw(800); // This should exceed overdraft
        }
    }
}
