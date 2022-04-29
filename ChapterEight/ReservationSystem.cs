namespace VisualCSharpHowToProgram.ChapterEight;

public class ReservationSystem
{
    public static void RunProgram()
    {
        const int capacity = 10;
        var plane = new bool[capacity];

        while (PlaneNotFull(plane))
        {
            var seatPick = Input.GetPositiveInteger("Enter 1 for first class or 2 for economy");

            switch (seatPick)
            {
                case 1:
                    ReserveFirstClass(plane);
                    break;
                case 2:
                    ReserveEconomyClass(plane);
                    break;
                default:
                    Console.WriteLine("Just enter the correct input");
                    break;
            }
            
            
        }
        
        
    }

    private static void ReserveEconomyClass(bool[] plane)
    {
        if (AreaFull(plane, plane.Length/2, plane.Length))
        {
            if (ReserveInOther("FirstClass"))
            {
                ReserveFirstClass(plane);
            }
            else
            {
                DisplayDeclineMessage();
            }
        }

        else
        {
            //reserve seat
        }
    }

    private static void ReserveFirstClass(bool[] plane)
    {
        if (AreaFull(plane, 0, plane.Length/2))
        {
            if (ReserveInOther("Economy Clas"))
            {
                ReserveEconomyClass(plane);
            }
            else
            {
                DisplayDeclineMessage();
            }
        }
        
    }
    private static void DisplayDeclineMessage()
    {
        Console.WriteLine("Next flight leaves in 3 hours");
    }

    private static bool ReserveInOther(string altClass)
    {
        Console.Write($"This class is full. Do you want to reserve in {altClass}? [Y/n]");
        var response = false;
        while (true)
        {
            try
            {
                var input = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                response = input switch
                {
                    'Y' or 'y' => true,
                    'N' or 'n' => false,
                    _ => response
                };
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        return response;
    }

    private static bool AreaFull(bool[] plane, int planeLength, int length)
    {
        throw new NotImplementedException();
    }


    


    //come back here to learn more about linq
    private static bool PlaneNotFull(IEnumerable<bool> plane) => plane.Any(seat => !seat);


}