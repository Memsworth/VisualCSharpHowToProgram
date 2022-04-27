namespace VisualCSharpHowToProgram.ChapterEight;

public class IdentifyEight
{
    public static void RunProgram()
    {
        int multipleSeen = 0;
        var arrayOfVal = new int[1];

        for (int i = 0; i < 5; i++)
        {
            int userInput = Input.GetNumberInRange("Enter between 1 and 1000", 1, 1000);
            if(userInput %)
        }
        
        
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