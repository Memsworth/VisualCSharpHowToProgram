using System.Threading.Channels;

namespace VisualCSharpHowToProgram.ChapterTen;

public static class DepreciatingValueTest
{
    public static void RunProgram()
    {
        var assetOne = new DepreciatingValue(5000000.0m, 10);
        var assetTwo = new DepreciatingValue(6000000.0m);
        var assetThree = new DepreciatingValue(7000000.0m);

        Console.WriteLine($"After depreciate rate of: {DepreciatingValue.AnnualDepreciationRate * 100:N}%");
        PrintAsset(assetOne, "one");
        PrintAsset(assetTwo, "two");
        PrintAsset(assetThree, "three");


        DepreciatingValue.ChangeRate(11);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Year: {i+1}");
            Console.WriteLine($"After depreciate rate of: {DepreciatingValue.AnnualDepreciationRate * 100:N}%");
            PrintAsset(assetOne, "1");
            PrintAsset(assetTwo, "2");
            PrintAsset(assetThree, "3");
        }
    }


    private static void PrintAsset(DepreciatingValue asset, string assetName)
    {
        Console.WriteLine($"Asset {assetName} before: {asset.ValueOfAsset:N}");
        asset.ChangeValue();
        Console.WriteLine($"Asset {assetName} after: {asset.ValueOfAsset:N}\n");
    }

}