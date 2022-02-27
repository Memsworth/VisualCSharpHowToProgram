namespace VisualCSharpHowToProgram;

public class Input
{
    public static int GetPositiveNumber(string message)
    {
        int input = 0;
        bool inputChecker = false;
        while (true)
        {
            Console.Write($"{message}: ");
            inputChecker = int.TryParse(Console.ReadLine(), out input);

            if (inputChecker && input > 0){break;}
        }

        return input;
    }
}