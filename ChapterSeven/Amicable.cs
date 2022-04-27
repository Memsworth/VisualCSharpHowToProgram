namespace VisualCSharpHowToProgram.ChapterSeven;

public static class Amicable
{
    public static void RunProgram()
    {
        var baseNum = Input.GetPositiveInteger("Enter base number");
        var amicableInput = Input.GetPositiveInteger("Enter number that is compared");

        var calculationResult = CheckAmicable(baseNum, amicableInput);
        Console.WriteLine($"Is the number amicable: {calculationResult.IsAmicable}");
        Console.WriteLine($"Amicable number: {calculationResult.AmicableValue}");
    }

    private struct AmicableResult
    {
        internal bool IsAmicable;
        internal int AmicableValue;
    }

    private static AmicableResult CheckAmicable(int baseNum, int resultNum)
    {
        AmicableResult calculationResult;

        var calculation = 0;

        for (int i = 1; i < baseNum; i++)
        {
            if (baseNum % i == 0)
            {
                calculation += i;
            }
        }

        if (calculation == resultNum)
        {
            calculationResult.IsAmicable = true;
            calculationResult.AmicableValue = calculation;
        }

        else
        {
            calculationResult.IsAmicable = false;
            calculationResult.AmicableValue = calculation;
        }

        return calculationResult;
    }
}