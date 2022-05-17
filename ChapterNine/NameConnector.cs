namespace VisualCSharpHowToProgram.ChapterNine;

public class NameConnector
{
    public static void StartProgram()
    {
        var names = new List<string>();
        const int  max = 10;
        
        for (int i = 0; i < max; i++)
        {
            Console.Write($"Enter name at position {i}: ");
            var nameInput = Console.ReadLine();
            if (nameInput != null) names.Add(nameInput);
        }

        var result = String.Join(',', names.Select(n => n.ToUpper()).OrderByDescending(n => n));
        var ascendString = String.Join(',', names.Select(n => n.ToUpper()).OrderBy(n => n)); 
        Console.WriteLine($"{result}");
        Console.WriteLine($"{ascendString}");


    }
}