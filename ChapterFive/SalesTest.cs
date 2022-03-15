namespace VisualCSharpHowToProgram.ChapterFive;

public class SalesTest
{
    private static readonly decimal[] Inventory = {239.99m, 129.75m, 99.95m, 350.89m};
    public static void RunTest()
    {
        double comissionRate = 0.09;
        decimal totalSale = 0.0m;
        int totalProductCounter = 0;

        int loopValidation = 0;
        do
        {
            ShowMenu();
            int userInput = Input.GetNumberInRange("Enter your input", 0, Inventory.Length-1);
            int productBought = GetProductBoughtAmount();
            totalProductCounter += productBought;
            totalSale += productBought * Inventory[userInput];
            loopValidation = Input.GetNumberInRange("Do you want to continue 0 = Yes, -1 = No", -1, 0);
        } while (loopValidation != -1);
        
        var EmployeeOne = new SalesEmployee(totalProductCounter, (decimal)comissionRate * totalSale);
        PrintEmployeePay(EmployeeOne);

    }
    
    private static int GetProductBoughtAmount() =>  Input.GetPositiveInteger("Enter amount bought");
    private static void ShowMenu()
    {
        Console.WriteLine("Welcome to the system.");
        Console.WriteLine("You will SELL this like the sales person you are");
        Console.WriteLine("Item\tPrice");
        Console.WriteLine($"0:  \t{Inventory[0]:C}");
        Console.WriteLine($"1:  \t{Inventory[1]:C}");
        Console.WriteLine($"2:  \t{Inventory[2]:C}");
        Console.WriteLine($"3:  \t{Inventory[3]:C}");
    }

    private static void PrintEmployeePay(SalesEmployee currentEmployee)
    {
        Console.WriteLine("Here's your pay structure: ");
        Console.WriteLine($"Your Salary: {currentEmployee.InitialSal:C}");
        Console.WriteLine($"Number of products sold: {currentEmployee.ProductSoldCount}");
        Console.WriteLine($"Commission earned: {currentEmployee.CommissionEarned:C} ");
        Console.WriteLine($"Total Pay: {currentEmployee.TotalPay:C}");
    }
}