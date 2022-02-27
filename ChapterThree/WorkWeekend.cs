using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class WorkWeekend
    {
        public static void Solution()
        {
            int dayInput = 0;

            Console.Write("Enter an int from 1~7: ");
            dayInput = int.Parse(Console.ReadLine());

            if(dayInput > 0 && dayInput < 6)
            {
                Console.WriteLine($"You entered {dayInput} and it is a working day.");
            }

            else if(dayInput == 6 || dayInput == 7)
            {
                Console.WriteLine($"You entered {dayInput} and it is a weekend.");
            }

            else
            {
                Console.WriteLine("Please do not be a retard. A week only has 7 days");
            }
        }
    }
}
