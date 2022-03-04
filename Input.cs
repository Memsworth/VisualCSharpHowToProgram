namespace VisualCSharpHowToProgram;

public class Input
{
    // Change and add in what sensei posted with generics & funcs
    // Look in further into generics and how to impelement them correctly
    // Re-write this file so it doesn't follow DRY.
   
    
    // TODO: Zombie CODE needs to be Deleted
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
    public static decimal GetPositiveDecimal(string message)
    {
        decimal input = 0.0m;
        bool inputChecker = false;
        while (true)
        {
            Console.Write(($"{message}: "));
            inputChecker = decimal.TryParse(Console.ReadLine(), out input);
            
            if(inputChecker && input > 0.0m) {break;}
        }

        return input;
    }
    
    // CODE PROVIDED BY mkbmain (My sensei)
    // Github: https://github.com/mkbmain
  
    //get better understanding of this part later on the day
    private static DateTime? StringToDateTime(string dateTime) =>
        DateTime.TryParse(dateTime, out var date) ? date : (DateTime?) null;
    private static decimal GetPositiveDeci(string message) => GetValue<decimal>(message, t => t > 0);
    public static int GetPositiveInteger(string message) => GetValue<int>(message, t => t > 0);
    public static double GetPositiveDouble(string message) => GetValue<double>(message, t => t>0);
    private static T GetValue<T>(string text, Func<T, bool> qualifies) where T : IConvertible
    {
        try
        {
            Console.Write($"{text}: ");
            var item = Console.ReadLine();
            var example = (T) Convert.ChangeType(item, typeof(T));
            if (qualifies(example))
            {
                return example;
            }
        }
        catch (Exception e)
        {
            // swallow exception
        }
            
        Console.WriteLine("Not a acceptable input please try again");
        return GetValue<T>(text, qualifies);
    }


}