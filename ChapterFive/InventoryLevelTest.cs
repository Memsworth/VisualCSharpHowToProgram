using System.Threading.Channels;

namespace VisualCSharpHowToProgram.ChapterFive;

public class InventoryLevelTest
{
    public static void RunTest()
    {
        int itemCode = Input.GetPositiveInteger("Enter item code");
        int unitsIssued = Input.GetPositiveInteger("Enter units issued");
        int openingUnits = Input.GetPositiveInteger("Enter opening units");
        Console.Write("Enter Display Name: ");
        string displayName = Console.ReadLine();
        if (String.IsNullOrEmpty(displayName))
        {
            displayName = "To be decided";
        }

        var partComputers = new InventoryLevelCalculator(itemCode, unitsIssued, openingUnits, displayName);
        var myPurchaseList = new List<PurchaseReceipt>();
        
        while (true)
        {
            Console.WriteLine("Enter -1 to quit\n");
            var unitInput = Input.GetPositiveNumber("Enter the amount of units to purchase");

            if (unitInput > partComputers.OpeningUnits)
            {
                Console.WriteLine("Contact logistics pls");
                continue;
            }
            
            var makeReceipt = partComputers.PurchaseUnit(unitInput);
            myPurchaseList.Add(makeReceipt);

            var uInput = int.Parse(Console.ReadLine()); 
            if (uInput == -1){break;}
        }

        Console.WriteLine("Displaying Receipts: ");
        foreach (var item in myPurchaseList)
        {
            Console.WriteLine($"Purchase date: {item.PurchaseDate}");
            Console.WriteLine($"Units Purchased: {item.UnitsPurchased}");
        }
    }
}