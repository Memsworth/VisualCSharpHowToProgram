namespace VisualCSharpHowToProgram.ChapterFive;

public class InventoryLevelCalculator
{
    private int _itemCode;
    private int _openingUnits;
    private int _totalUnitsPurchased;
    private int _unitsIssued;
    // check if I can put list in separate file
    public string DisplayName { get; set; }
    public int ItemCode
    {
        get => _itemCode;
        set
        {
            if(value > 0)
            {
                _itemCode = value;
            }
        }
    }
    
    public int UnitsIssued
    {
        get => _unitsIssued;
        set
        {
            if (value > 0)
            {
                _unitsIssued = value;
            }
        }
    }
    public int OpeningUnits
    {
        get => _openingUnits;
        set
        {
            // add in case for if in stock is less than opening
            // case: can values of Opening units be larger than Units Issued? (Return/Refunded units)
            if (value <= 0) return;
            if (value <= UnitsIssued)
            {
                _openingUnits = value;
            }
        }
    }

    //A
    public int TotalUnitsPurchased
    {
        get => _totalUnitsPurchased;
    }

    public InventoryLevelCalculator(int itemCode, int unitsIssued, int openingUnits, string displayName)
    {
        ItemCode = itemCode;
        UnitsIssued = unitsIssued;
        OpeningUnits = openingUnits;
        DisplayName = displayName;
    }

        
    public PurchaseReceipt PurchaseUnit(int unitsBought)
    {
        var receipt = new PurchaseReceipt(DateTime.Now, unitsBought);
        _totalUnitsPurchased += unitsBought;
        ReduceUnits(unitsBought);
        return receipt;
    }

    private void ReduceUnits(int unitsBought)
    {
        _openingUnits -= unitsBought;
    }

}