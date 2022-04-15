using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class PythagoreanTriples
    {
        public static void RunTest()
        {
            const int MaxValue = 500;

            for (int a = 1; a <= MaxValue; a++)
            {
                for (int b = 1; b <= MaxValue; b++)
                {
                    for (int c = 1; c <= MaxValue; c++)
                    {
                        if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2))
                        {
                            Console.WriteLine($"{a}, {b} &, {c} make a triangle\n");
                        }
                    }
                }
            }
        }
    }
}
