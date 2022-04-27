namespace VisualCSharpHowToProgram.ChapterEight;

public class WageRateEmp
{
    public int EmpID { get; }
    public decimal EmpPay { get; }

    public WageRateEmp(int id, decimal empPay)
    {
        EmpID = id;
        EmpPay = empPay;
    }
}