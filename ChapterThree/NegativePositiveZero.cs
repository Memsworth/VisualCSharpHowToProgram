using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class NegativePositiveZero
    {
        public static void Solution()
        {
            const int loopInput = 5;
            for (int i = 0; i < loopInput; i++)
            {
                Console.Write("Enter an number: ");
                float numberInput = float.Parse(Console.ReadLine());
                if (numberInput > 0) { Console.WriteLine($"{numberInput} is a positive number"); }
                else if (numberInput < 0) { Console.WriteLine($"{numberInput} is a negative number"); }
                else { Console.WriteLine($"It is a zero"); }
            }
        }
    }
}
