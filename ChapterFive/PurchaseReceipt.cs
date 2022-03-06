namespace VisualCSharpHowToProgram.ChapterFive;

public class PurchaseReceipt
{
    public PurchaseReceipt(DateTime date, int units)
    {
        this.PurchaseDate = date;
        this.UnitsPurchased = units;
    }
    public DateTime PurchaseDate { get; set; }
    public int UnitsPurchased { get; set; }
}