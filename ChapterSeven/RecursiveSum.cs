namespace VisualCSharpHowToProgram.ChapterSeven;

public class RecursiveSum
{
    public static void StartProgram()
    {
        const int minVal = 10;
        const int maxVal = 99999;

        var numInput = Input.GetNumberInRange("Enter a number", minVal, maxVal);
        int sumDigits = SumOfDigits(numInput);
        Console.WriteLine($"sum of {numInput} digits are: {sumDigits}");
    }

    private static int SumOfDigits(int number)
    {
        if (number < 10)
        {
            return number;
        }
        
        return (number % 10) + SumOfDigits(number / 10);
    }
}