using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class Budgeting
    {
        public static void Solution()
        {
            decimal monthIncome = 0.0m;
            decimal monthExpense = 0.0m;
            bool checker = true;
            
            while(true)
            {
                Console.Write("Enter monthly income: ");
                checker = decimal.TryParse(Console.ReadLine(), out monthIncome);
                if (checker)
                {
                    Console.Write("Enter monthly expense: ");
                    checker = decimal.TryParse(Console.ReadLine(), out monthExpense);
                }
                if(checker)
                {
                    if(monthIncome > monthExpense && (monthIncome>0 && monthExpense > 0)) { break; }
                }
            }

            decimal monthlySavings = monthIncome - monthExpense;
            double savingsRatio = (double)monthlySavings/(double)monthIncome;


            Console.WriteLine($"Your monthly income: {monthIncome}");
            Console.WriteLine($"Your monthly expense: {monthExpense}");
            Console.WriteLine($"Your monthly savings: {monthlySavings}");
            Console.WriteLine($"Your savings ratio: {savingsRatio}");

            Console.WriteLine("Savings Ratio Analysis\n" +
                "< 0.20 Extravagant or Low on Savings\n" +
                "> 0.20 but < 0.40 Less Extravagant or Moderate on Savings\n" +
                "> 0.40 but < 0.75 Lively or Strong on Savings\n" +
                "> 0.75 Miser or Mad about Savings");
        }
    }
}
