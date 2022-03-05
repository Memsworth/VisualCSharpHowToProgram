namespace VisualCSharpHowToProgram.ChapterFive;

public class InventoryLevelCalculator
{
    private int _itemCode;
    private int _openingUnits;
    private int _unitsPurchased;
    private int _unitsIssued;
    
    public string UnitName { get; private set; }

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

    public int OpeningUnits
    {
        get => 
    }


}