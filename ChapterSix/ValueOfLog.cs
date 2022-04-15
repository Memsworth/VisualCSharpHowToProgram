using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class ValueOfLog
    {
        public static void RunTest()
        {
            int userInput = Input.GetPositiveInteger("Enter number of terms");
            double result = Math.Log(userInput);

            Console.WriteLine($"after number of {userInput} terms: {result:N}");
        }
    }
}
