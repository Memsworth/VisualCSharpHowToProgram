namespace VisualCSharpHowToProgram.ChapterEight;

public static class SalesReport
{
    private static readonly Random Rand = new Random();
    private static readonly decimal[] Stock = new decimal[]  { 50.0m, 132.4m, 25.0m, 100.0m, 36.0m };
    
    public static void RunProgram()
    {
        var data = new List<Slip>();
        PopulateData(data);

        var tabularData = new decimal[4, 6];

        foreach (var slip in data)
        {
            tabularData[slip.SalesPerson, slip.ProductNumber] += slip.SalesValue;
        }

        PopulateTotal(tabularData);

        PrintTable(tabularData);
    }

    private static void PrintTable(decimal[,] tabularData)
    {
        for (int i = 0; i < tabularData.GetLength(0); i++)
        {
            for (int j = 0; j < tabularData.GetLength(1); j++)
            {
                Console.Write($"{tabularData[i,j]}\t");
            }
            
            Console.WriteLine();
        }
    }

    private static void PopulateTotal(decimal[,] tabularData)
    {
        for (int i = 0; i < tabularData.GetLength(0)-1; i++)
        {
            decimal totalAmount = 0.0m;
            for (int j = 0; j < tabularData.GetLength(1)-1; j++)
            {
                totalAmount += tabularData[i, j];
            }
            tabularData[i, 5] = totalAmount;
        }

        for (int i = 0; i < tabularData.GetLength(1)-1; i++)
        {
            decimal totalAmount = 0.0m;
            for (int j = 0; j < tabularData.GetLength(0) - 1; j++)
            {
                totalAmount += tabularData[j, i];
            }

            tabularData[3, i] = totalAmount;
        }

        decimal finalAmount = 0.0m;
        for (int i = 0; i < tabularData.GetLength(0); i++)
        {
            finalAmount += tabularData[i, tabularData.GetLength(1)-1];
        }

        tabularData[tabularData.GetLength(0)-1, tabularData.GetLength(1)-1] = finalAmount;
    }

    private static void PopulateData(ICollection<Slip> data)
    {
        for (int day = 0; day < 30; day++)
        {
            for (int personId = 0; personId < 3; personId++)
            {
                var confirmedSlips = Rand.Next(0, 6);
                if (confirmedSlips == 0)
                    Console.WriteLine("No sale");
                else 
                {
                    for (int slipCount = 0; slipCount < confirmedSlips; slipCount++)
                    {
                        var productId = Rand.Next(0, 5);
                        var purchaseReceipt = new Slip(personId, productId, Stock[productId]);
                        data.Add(purchaseReceipt);
                    }
                }
                
            }
        }
    }
}