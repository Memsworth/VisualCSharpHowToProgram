using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSeven
{
    internal class FindMin
    {
        public static void RunTest()
        {
            double numOne = GetInput();
            double numTwo = GetInput();
            double numThree = GetInput();

            Console.WriteLine($"Min value between three value is: {Minimum3(numOne,numTwo, numThree)}");
        }

        private static double GetInput() => Input.GetDoubleNumber("Enter a number");

        private static double Minimum3(double valOne, double valTwo, double valThree) =>
            Math.Min(valOne, Math.Min(valTwo, valThree));
    }
}
