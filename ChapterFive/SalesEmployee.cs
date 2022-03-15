namespace VisualCSharpHowToProgram.ChapterFive;

public class SalesEmployee
{
    
    private const decimal InitialSalary = 200.0m;
    private decimal _totalPay;
    private decimal _commissionEarned;
    private int _productSoldCount;

    
    public decimal InitialSal => InitialSalary;

    public decimal CommissionEarned
    {
        get => _commissionEarned;
        set
        {
            if (value >= 0.0m)
            {
                _commissionEarned = value;
            }
        }
    }

    public int ProductSoldCount
    {
        get => _productSoldCount;
        set
        {
            if (value > 0)
            {
                _productSoldCount = value;
            }
        }
    }
    public decimal TotalPay
    {
        get => _totalPay;
        //Code smell possibility check
        set
        {
            if (value>0)
            {
                _totalPay = value;
            }
        }
    }

    public SalesEmployee(int productSoldCount, decimal commissionEarned)
    {
        ProductSoldCount = productSoldCount;
        CommissionEarned = commissionEarned;
        TotalPay = CommissionEarned + InitialSal;
    }
}