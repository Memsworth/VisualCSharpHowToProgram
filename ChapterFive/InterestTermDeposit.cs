namespace VisualCSharpHowToProgram.ChapterFive;

public class InterestTermDeposit
{
    //Keep interest rate flexible
    private double _interestRate;
    
    // Starting investment & date are const like values
    private readonly int _initialInvestment;
    private readonly DateOnly _initialInvestmentDate;

    private double InterestRate
    {
        get => _interestRate;
        set
        {
            if (value is >0.0 and <=0.10)
            {
                _interestRate = value;
            }
        }
    }

    private int InitialInvestment
    {
        get => _initialInvestment;
        init
        {
            if (value > 0)
            {
                _initialInvestment = value;
            }
        }
    }

    private DateOnly InitialInvestmentDateOnly
    {
        get => _initialInvestmentDate;
        init
        {
            if ((DateOnly)value <= DateOnly.FromDateTime(DateTime.Today))
            {
                _initialInvestmentDate = value;
            }
        }
    }
    
    public InterestTermDeposit(double interestRate, int initialInvestment, DateOnly initialInvestmentDate)
    {
        InterestRate = interestRate;
        InitialInvestment = initialInvestment;
        InitialInvestmentDateOnly = initialInvestmentDate;
    }
}