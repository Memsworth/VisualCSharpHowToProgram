using VisualCSharpHowToProgram;

namespace VisualCsharpHowToProgram.ChapterFour;

public class AssetTest
{
    private const decimal IncreaseRate = 0.05m;
    public static void RunTest()
    {
        var myAsset = new Asset("Gold coin", 56.4m, 0.10m);
        AssetPrint(myAsset);

        Console.WriteLine($"Asset value after {IncreaseRate*100}% rate increase");
        myAsset.IncreaseAssetValue(IncreaseRate);
        AssetPrint(myAsset);

        int years = Input.GetPositiveNumber("Enter number of years");

        Console.WriteLine($"value after depreciate of {years} years");
        myAsset.SetValueAfterDepreciation(years);
        AssetPrint(myAsset);
    }

    private static void AssetPrint(Asset myAsset)
    {
        Console.WriteLine($"Asset Name: {myAsset.AssetName}");
        Console.WriteLine($"Asset Value: {myAsset.AssetValue:N}");
        Console.WriteLine($"Asset depreciation rate: {myAsset.DepreciationRate}");
    }


}