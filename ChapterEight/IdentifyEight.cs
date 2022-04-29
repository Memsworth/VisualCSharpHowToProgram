namespace VisualCSharpHowToProgram.ChapterEight;

public class IdentifyEight
{
    public static void RunProgram()
    {
        var arrayOfVal = Array.Empty<int>();
        
        for (int i = 0; i < 5; i++)
        {
            int userInput = Input.GetNumberInRange("Enter between 1 and 1000", 1, 1000);
            if (userInput % 8 != 0) continue;
            Array.Resize(ref arrayOfVal, arrayOfVal.Length + 1);
            arrayOfVal[^1] = userInput;
        }
        
        DisplayArray(arrayOfVal);
    }

    private static void DisplayArray(int[] valArr)
    {
        foreach (var value in valArr)
        {
            Console.Write($" {value} ");
        }

        Console.WriteLine();
    }
}