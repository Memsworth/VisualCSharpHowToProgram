using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class Factorial
    {
        public static void RunTest()
        {
            int userInput = Input.GetPositiveInteger("Enter a non negative integer");


            int factorial = GetFactorial(userInput);
            Console.WriteLine($"{factorial}");
        }

        protected static int GetFactorial(int userInput)
        {
            if (userInput == 0) { return 1; }
            else
            {
                return userInput * GetFactorial(userInput - 1);
            }
            throw new NotImplementedException();
        }
    }
}
