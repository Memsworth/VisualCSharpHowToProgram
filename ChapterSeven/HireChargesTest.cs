using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSeven
{
    internal class HireChargesTest
    {
        public static void RunTest()
        {
            double distanceTravelled = Input.GetPositiveDouble("Enter distance travelled");
            int waitTimeHours = Input.GetNumberInRange("Enter wait time", 0, 24);

            var sakuraCustomer = new Customer(distanceTravelled, waitTimeHours);
            var memsworthCab = new CabDriver();


            decimal cost = memsworthCab.FindCabFare(sakuraCustomer.TravelDistance,
                                                    sakuraCustomer.WaitTime);

            sakuraCustomer.Cost = cost;
            memsworthCab.AddPay(sakuraCustomer.Cost);

            PrintCustomer(sakuraCustomer);
            PrintCab(memsworthCab);
        }

        private static void PrintCab(CabDriver currentCab)
        {
            Console.WriteLine("====================================\n");
            Console.WriteLine("Cab's total Fare");
            Console.WriteLine($"Total pay of the cab driver: {currentCab.TotalPay:C}");
            Console.WriteLine("\n====================================");

        }

        private static void PrintCustomer(Customer CurrentCustomer)
        {
            Console.WriteLine("====================================\n");
            Console.WriteLine("Customer cab cost");
            Console.WriteLine($"Total distance travelled: {CurrentCustomer.TravelDistance:N} KM");
            Console.WriteLine($"Wait time: {CurrentCustomer.WaitTime} HRs");
            Console.WriteLine($"Cost of cab fee: {CurrentCustomer.Cost:C}");
            Console.WriteLine("\n====================================");

        }
    }
}
