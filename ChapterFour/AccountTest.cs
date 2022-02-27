namespace VisualCsharpHowToProgram.ChapterFour;

public class AccountTest
{
    public static void StartTest()
    {
        var accountOne = new Account("Abu Ahmet", -95.1m);

        Console.WriteLine($"Account One");
        Console.WriteLine($"Account owned by: {accountOne.Name} & initial balance is: {accountOne.Balance}");

        Console.WriteLine("We will deposit into the account");
        Console.Write("Enter deposit amount: ");
        decimal userInput = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"Deposited Amount: {userInput}"); 
        accountOne.Deposit((userInput));
        Console.WriteLine($"Current balance: {accountOne.Balance}");

        Console.Write("Enter money to withdraw: ");
        userInput = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"withdraw amount: {userInput}");
        accountOne.Withdraw(userInput);
        Console.WriteLine($"Current balance: {accountOne.Balance}");
    }
}