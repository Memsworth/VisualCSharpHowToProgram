namespace VisualCSharpHowToProgram.ChapterSeven;

public class TowerHanoi
{
    public static void StartProgram()
    {
        var towerInput = Input.GetPositiveInteger("Enter number of disk");

        Tower(towerInput, 1, 3, 2);
    }

    private static void Tower(int diskNum, int startPeg, int endPeg, int tempPeg)
    {
        if (diskNum < 1) return;
        Tower(diskNum-1, startPeg, tempPeg, endPeg);
        Console.WriteLine($"{startPeg} ---> {endPeg}");
        Tower(diskNum-1, tempPeg, endPeg, startPeg);
    }
}