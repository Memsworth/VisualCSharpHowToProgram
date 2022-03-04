namespace VisualCSharpHowToProgram.ChapterFive;

public class InterestTermTest
{
    public static void RunTest()
    {
        //ADD ID like string to identify investment (make it random)

        var interestRate = Input.GetPositiveDouble("Enter your interest rate");
        var initialInvestment = Input.GetPositiveInteger("Enter your initial investment amount");
        
        Console.Write("Enter date of investment: ");
        DateTime userDateTime;
        userDateTime = DateTime.Parse(Console.ReadLine());
        var initialInvestmentDate = DateOnly.FromDateTime(userDateTime);

        
        var portfolioOne = new InterestTermDeposit(interestRate, initialInvestment, initialInvestmentDate);
        
        PrintInvestment(portfolioOne);
        PrintExpectedInvestment(portfolioOne);        
    }


    private static void PrintExpectedInvestment(InterestTermDeposit currentInvestment)
    {
        //placeholder
        var investedMonths = Input.GetPositiveInteger("Months duration");
        var initialValue = currentInvestment.InitialInvestment;
        for (int i = 1; i <= investedMonths; i++)
        {
            Console.WriteLine($"Date: {currentInvestment.InitialInvestmentDateOnly.AddMonths(i).ToString("d")}");
            Console.WriteLine($"Interest rate: {currentInvestment.InterestRate:P}");
            Console.WriteLine($"Previous amount: {initialValue:C}");
            initialValue = (int) (initialValue + (currentInvestment.InitialInvestment * currentInvestment.InterestRate));
            Console.WriteLine($"After interest rate: {initialValue:C}\n\n");
        }
    }
    private static void PrintInvestment(InterestTermDeposit currentInvestment)
    {
        Console.Clear();
        Console.WriteLine("Your investment: ");
        Console.WriteLine($"Date of investment: {currentInvestment.InitialInvestmentDateOnly}");
        Console.WriteLine($"Initial investment amount: {currentInvestment.InitialInvestment:C}");
        Console.WriteLine($"Interest rate: {currentInvestment.InterestRate:P}\n\n");
    }
}