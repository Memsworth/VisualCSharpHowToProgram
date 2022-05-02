namespace VisualCSharpHowToProgram.ChapterEight;

public class Slip
{
    public Slip(int salesPerson, int productNumber, decimal salesValue)
    {
        SalesPerson = salesPerson;
        ProductNumber = productNumber;
        SalesValue = salesValue;
    }

    public int SalesPerson { get; }
    public int ProductNumber { get; }
    public decimal SalesValue { get; }
}