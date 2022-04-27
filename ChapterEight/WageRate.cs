namespace VisualCSharpHowToProgram.ChapterEight;

public static class WageRate
{
    public static void RunProgram()
    {
        const decimal basePay = 200.0m;
        const decimal overtimePay = 10.0m;
        const int maxTime = 48;
        var employeeChart = new List<WageRateEmp>();
        int empid = 1;

        while (true)
        {
            Console.WriteLine($"Employee ID: {empid}");
            var finishInput = Input.GetPositiveInteger("Enter finish time");
            int overtimeDuration = (maxTime - finishInput);
            if (overtimeDuration < 0)
            {
                overtimeDuration = 0;
            }
            
            decimal employeePay = basePay + overtimePay * overtimeDuration;

            var currentEmp = new WageRateEmp(empid, employeePay);
            employeeChart.Add(currentEmp);
            empid++;

            int getStatus = Input.GetNumberInRange("Enter 0 to finish or 1 to continue", 0, 1);
            if(getStatus == 0){break;}
        }
       

        DisplayChart(employeeChart, basePay);
    }

    private static void DisplayChart(List<WageRateEmp> employeeChart, decimal basePay)
    {
        var payFrequency = new int[9];

        foreach (var employee in employeeChart)
        {
            int payPoint = (int)(employee.EmpPay - basePay) / 10;
            
            if (payPoint >= 8)
            {
                payPoint = 8;
            }

            payFrequency[payPoint]++;
        }

        PrintChart(payFrequency);
    }

    private static void PrintChart(int[] payFrequency)
    {
        for (int i = 0; i < payFrequency.Length; i++)
        {
            Console.Write(i == 8 ? "280 or more: " : $"{i*10 + 200}-{i*10 + 209}: ");

            for (var stars = 0; stars < payFrequency[i]; ++stars)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}