namespace VisualCSharpHowToProgram.ChapterSeven;

public class CoinToss
{
    public static void RunProgram()
    {
        int heads = 0;
        int tails = 0;

        for (int i = 0; i < 50000; i++)
        {
            if (Flip())
            {
                heads++;
            }
            else
            {
                tails++;
            }
        }

        Console.WriteLine("This is after 50000 runs");
        Console.WriteLine($"heads: {heads}");
        Console.WriteLine($"tails: {tails}");
    }

    private static bool Flip()
    {
        var rand = new Random();
        int val = rand.Next(2);

        return val == 1;
    }
}