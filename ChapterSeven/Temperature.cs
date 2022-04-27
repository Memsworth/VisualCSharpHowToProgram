namespace VisualCSharpHowToProgram.ChapterSeven;

public class Temperature
{
    public static void StartProgram()
    {
        int tempChoiceInput = Input.GetNumberInRange("Enter 0 to convert from C to F." +
                                                     "\nEnter 1 to convert from F to C", 0, 1);

        switch (tempChoiceInput)
        {
            case (int)TempChoice.Celsius:
            {
                double celsiusInput = TempInput("celsius");
                Console.WriteLine($"{celsiusInput:N}C to f is: {Fahrenheit(celsiusInput):N}");
                break;
            }
            case (int)TempChoice.Fahrenheit:
            {
                double fahrenheitInput = TempInput("fahrenheit");
                Console.WriteLine($"{fahrenheitInput:N}F to C is: {Celsius(fahrenheitInput):N}");
                break;
            }
        }
    }

    private enum TempChoice
    {
        Celsius,
        Fahrenheit
    };

    private static double TempInput(string temp) => Input.GetDoubleNumber($"Enter a {temp} temperature");
    private static double Celsius(double fahrenheit) => 5.0 / 9.0 * (fahrenheit - 32);
    private static double Fahrenheit(double celsius) => 9.0 / 5.0 * celsius + 32;
}