namespace VisualCSharpHowToProgram.ChapterNine;

public class PetName
{
    public static void StartProgram()
    {
        var petCount = Input.GetPositiveInteger("How many pets");
        var petNames = new List<string>();

        for (int i = 0; i < petCount; i++)
        {
            Console.Write("Enter pet name: ");
            var petInput = Console.ReadLine();
            if (petInput != null) petNames.Add(petInput);
        }

        var resultOne = petNames.OrderBy(n => n.Length);
        var resultTwo = petNames.OrderByDescending(n => n.Length);
        var removeDupli = petNames.OrderBy(n => n.Length).Distinct();
        
        foreach (var name in removeDupli)
        {
            Console.WriteLine($"{name}");
        }
    }
}