namespace VisualCSharpHowToProgram.ChapterEight;

public class DiceRolling
{
    private static Random rand = new Random();

    public static void RunProgram()
    {

        var diceFrequency = new int[12];

        const int maxRolls = 36000;

        for (int i = 0; i < maxRolls; i++)
        {
            int result = (RollDice() + RollDice()) - 1;
            diceFrequency[result]++;
        }

        for (int i = 0; i < diceFrequency.Length; i++)
        {
            Console.WriteLine($"{i+1}: {diceFrequency[i]}");
        }
    }

    private static int RollDice() => rand.Next(1, 7);
}