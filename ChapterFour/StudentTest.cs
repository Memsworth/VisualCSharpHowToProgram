namespace VisualCsharpHowToProgram.ChapterFour;

public class StudentTest
{
    public static void RunTest()
    {
        var studentOne = new Student("XA2451", "Ahmet", -87, 32, 100);

        PrintDetails(studentOne);

        //BOILER plate code to test
        Console.Write("Enter value to fix score one: ");
        decimal numberInput = decimal.Parse((Console.ReadLine()));

        studentOne.ChangeScore(numberInput, 1);
        
        Console.Write("Enter value to fix score three: ");
        numberInput = decimal.Parse((Console.ReadLine()));
        
        studentOne.ChangeScore(numberInput, 3);

        PrintDetails(studentOne);
        
    }

    private static void PrintDetails(Student studentDetails)
    {
        Console.WriteLine("Printing details: ");
        Console.WriteLine($"Student ID: {studentDetails.StudentId}");
        Console.WriteLine($"Student Name: {studentDetails.StudentName}");
        Console.WriteLine($"Score 1: {studentDetails.ScoreOne}");
        Console.WriteLine($"Score 2: {studentDetails.ScoreTwo}");
        Console.WriteLine($"Score 3: {studentDetails.ScoreThree}");
        Console.WriteLine($"Aggregate: {studentDetails.GetAggregate()}");
        Console.WriteLine($"Percentage: {studentDetails.GetPercentage():N}%");
    }
}