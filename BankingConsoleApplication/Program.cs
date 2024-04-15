// See https://aka.ms/new-console-template for more information

// Task 1: Setting Up the Account
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Banking Application ");
        Console.WriteLine("--------------------------------------");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your initial deposit: ");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

        BankAccount account = new BankAccount(name, accountNumber, initialDeposit);
        Console.WriteLine("\nAccount setup successful!\n");

        account.RunBankingApplication();
    }
}
