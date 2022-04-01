using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class ConstantE : Factorial
    {
        public static new void RunTest()
        {
            var e = 1.0;

            for (int i = 1; i < 15; i++)
            {
                e += 1.0 / GetFactorial(i);
            }

            Console.WriteLine($"This is approx to 15 approx {e}");
        }
    }
}
