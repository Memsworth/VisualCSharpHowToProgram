namespace VisualCSharpHowToProgram.ChapterFour;

public class CoachingTest
{
    public static void RunTest()
    {
        Console.Write("Enter the type of coaching you will provide: ");
        string coachType = Console.ReadLine();

        if (String.IsNullOrEmpty(coachType))
        {
            coachType = "To be decided";
        }
        Console.Write("Enter the timings you will coach for: ");
        string classTimings = Console.ReadLine();

        if (String.IsNullOrEmpty(classTimings))
        {
            classTimings = "To be decided";
        }
        int playerCount = Input.GetPositiveNumber("Enter player count for coaching");
        decimal coachCharges = Input.GetPositiveDecimal("How much will you charge for this");

        var coachingOne = new Coaching(playerCount, coachCharges, classTimings, coachType);
        
        PrintCoachingDetails(coachingOne);
    }

    private static void PrintCoachingDetails(Coaching currentCoaching)
    {
        Console.Clear();
        Console.WriteLine($"CoachType: {currentCoaching.CoachType}");
        Console.WriteLine($"Coaching Timings: {currentCoaching.ClassTimings}");
        Console.WriteLine($"Player Count: {currentCoaching.PlayerCount}");
        Console.WriteLine($"Coaching Charges: {currentCoaching.CourseCharge:C}");
    }
}