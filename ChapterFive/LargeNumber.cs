using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class LargeNumber
    {
        public static void RunTest()
        {
            int largeNumber = 0;
            int secondNumber = 0;
            const int limit = 10;
            for (int i = 0; i < limit; i++)
            {
                int userInput = Input.GetPositiveInteger("Enter a number");
                if(largeNumber<=userInput)
                {
                    secondNumber = largeNumber;
                    largeNumber = userInput;
                }
                else if(secondNumber<=userInput)
                {
                    secondNumber = userInput;
                }
            }

            Console.WriteLine($"Largest number is: {largeNumber}");
            Console.WriteLine($"Secon Large number is: {secondNumber}");
        }
    }
}
