namespace VisualCsharpHowToProgram.ChapterFour;

public class Asset
{
    
    public string AssetName { get; set; }
    private decimal _assetValue;
    private decimal _depreciationRate;

    public decimal AssetValue
    {
        get => _assetValue;
        private set
        {
            if (value > 0.0m)
            {
                _assetValue = value;
            }
        }
    }
    public decimal DepreciationRate
    {
        get => _depreciationRate;

        private set
        {
            if (value > 0.0m)
            {
                _depreciationRate = value;
            }
        }
    }

    public Asset(string assetName, decimal assetValue, decimal depreciationRate)
    {
        AssetName = assetName;
        AssetValue = assetValue;
        DepreciationRate = depreciationRate;
    }

    public void IncreaseAssetValue(decimal rate)
    {
        if (rate > 0.0m)
        {
            AssetValue = Decimal.Multiply(AssetValue, rate) + AssetValue;
        }

        else
        {
            Console.WriteLine("Asset values can't be negative");
        }
    }

    public void SetValueAfterDepreciation(int years)
    {
        for (int i = 0; i < years; i++)
        {
            AssetValue = AssetValue - Decimal.Multiply(AssetValue, DepreciationRate);
        }
    }
}