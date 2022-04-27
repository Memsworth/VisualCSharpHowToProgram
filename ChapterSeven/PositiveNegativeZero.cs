namespace VisualCSharpHowToProgram.ChapterSeven;

public class PositiveNegativeZero
{
    public static void RunTest()
    {
        var userInput = Input.GetNumber("Enter a valid number");

        switch (FindIntType(userInput))
        {
            case (int) IntType.Negative:
                Console.WriteLine("Negative Number");
                break;
            case (int) IntType.Positive:
                Console.WriteLine("Positive Number");
                break;
            case (int) IntType.Zero:
                Console.WriteLine("Zero!");
                break;
        }
        
    }

    private enum IntType
    {
        Negative = -1,
        Zero = 0,
        Positive = 1
    };
    
    private static int FindIntType(int inputValue) => Math.Abs(inputValue) > inputValue ? -1 : (inputValue > 0) ? 1 : 0;
}