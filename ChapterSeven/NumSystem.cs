namespace VisualCSharpHowToProgram.ChapterSeven;

public class NumSystem
{
    public static void RunProgram()
    {
        var byteInput = Input.GetNumberInRange("Enter a value between 1 and 256", byte.MinValue+1, byte.MaxValue);
        var binVal = Convert.ToString(byteInput, 2);
        var octVal = Convert.ToString(byteInput, 8);
        var hexVal = Convert.ToString(byteInput, 16);

        Console.WriteLine($"The binary representation is: {binVal}");
        Console.WriteLine($"The octal representation is: {octVal}");
        Console.WriteLine($"The hex representation is: {hexVal}");
    }
}