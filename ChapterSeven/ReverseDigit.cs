namespace VisualCSharpHowToProgram.ChapterSeven;

public class ReverseDigit
{
    public static void StartProgram()
    {
        var numInput = Input.GetPositiveInteger("Enter a digit to be reversed");
        int reversedDigit = 0;

        Console.WriteLine($"The input digit is: {numInput}"); 
        while (numInput != 0)
        {
            int remainder = numInput % 10;
            reversedDigit = reversedDigit * 10 + remainder;
            numInput = numInput / 10;
        }

        Console.WriteLine($"Reversed digit is: {reversedDigit}");
    }
}