namespace VisualCSharpHowToProgram.ChapterEight;

public class TortoiseHare
{
    private static readonly Random Random = new Random();
    private const int Max = 70;
    
    public static void StartProgram()
    {
        int harePosition = 0;
        int tortoisePosition = 0;
        bool gameEnd=false;
        DisplayStartMessage();
        do
        {
            harePosition = HareMovement(harePosition);
            tortoisePosition = TortoiseMovement(tortoisePosition);
            DisplayPosition(harePosition, tortoisePosition);
            Console.WriteLine();
            if (harePosition >= Max || tortoisePosition >= Max)
                gameEnd = true;
            
        } while (!gameEnd);
        
        DisplayEndSim(harePosition, tortoisePosition);
    }

    private static void DisplayEndSim(int harePosition, int tortoisePosition)
    {
        if (harePosition>tortoisePosition)
        {
            Console.WriteLine("Hare wins. Yuch.");
        }
        else if (tortoisePosition> harePosition)
        {
            Console.WriteLine("TORTOISE WINS!!! YAY!!!");
        }
        else
        {
            Console.WriteLine("It is a tie");
        }
    }

    private static void DisplayStartMessage()
    {
        Console.WriteLine("ON YOUR MARK, GET SET");
        Console.WriteLine("BANG !!!!!");
        Console.WriteLine("AND THEY'RE OFF !!!!!");
    }

    private static void DisplayPosition(int harePosition, int tortoisePosition)
    {
        for (int i = 0; i < Max; i++)
        {
            if (tortoisePosition == harePosition && tortoisePosition == i)
            {
                Console.Write("OUCH!!!");
            }

            else
            {
                if (harePosition == i)
                {
                    Console.Write("H");
                }

                Console.Write(tortoisePosition == i ? "T" : $"-");
            }
            
           
        }

    }

    private static int HareMovement(int harePosition)
    {
        var movement = Random.Next(1, 11);
        int positionUpdate = 0;
        switch (movement)
        {
            case 1:
            case 2:
                positionUpdate = harePosition;
                break;
            case 3:
            case 4:
                positionUpdate = harePosition + 9;
                break;
            case 5:
                positionUpdate = harePosition - 12;
                break;
            case 6:
            case 7: 
            case 8:
                positionUpdate = harePosition + 1;
                break;
            case 9:
            case 10:
                positionUpdate = harePosition - 2;
                break;
        }

        if (positionUpdate < 0)
            positionUpdate = 0;
        
        return positionUpdate;
    }

    private static int TortoiseMovement(int tortoisePosition)
    {
        var movement = Random.Next(1, 11);
        int positionUpdate = 0;
        switch (movement)
        {
            case 1:
            case 2: 
            case 3: 
            case 4:
            case 5:
                positionUpdate = tortoisePosition + 3;
                break;
            case 6:
            case 7: 
                positionUpdate = tortoisePosition - 6;
                break; 
            case 8:
            case 9:
            case 10:
                positionUpdate = tortoisePosition + 1;
                break;
        }

        if (positionUpdate < 0)
            positionUpdate = 0;
        
        return positionUpdate;
    }

}