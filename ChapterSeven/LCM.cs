namespace VisualCSharpHowToProgram.ChapterSeven;

public class Lcm
{
    public static void RunProgram()
    {
        Console.WriteLine("This is to find LCM");
        var inputOne = Input.GetPositiveInteger("Enter first input");
        var inputTwo = Input.GetPositiveInteger("Enter second input");

        int lcmVal = Math.Max(inputOne,inputTwo);
        var isLcm = false;

        while (true)
        {
            if (lcmVal % inputOne == 0 && lcmVal % inputTwo == 0)
            {
                isLcm = true;
                break;
            }
            else
            {
                lcmVal++;
            }
        }


        Console.WriteLine(isLcm ? $"The lcm of val {inputOne} and {inputTwo}: {lcmVal}" : "There is no LCM");
    }
}