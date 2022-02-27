namespace VisualCsharpHowToProgram.ChapterFour;

public class Account
{
    public string Name { get; set; }
    private decimal _balance;

    public Account(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }

    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value > 0.0m)
            {
                _balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }

    public void Withdraw(decimal withdrawAmount)
    {
        if (withdrawAmount > 0.0m)
        {
            if (Balance > withdrawAmount)
            {
                Balance = Balance - withdrawAmount;
            }
            else
            {
                Console.WriteLine("Operation invalid. Withdraw more than balance");
            }
        }

        else
        {
            Console.WriteLine("Operation invalid. Not the correct input");
        }
    }
}