using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class Multiples
    {
        public static void Solution()
        {
            Console.Write("Enter int: ");
            int inputOne = int.Parse(Console.ReadLine());

            Console.Write("Enter int: ");
            int inputTwo = int.Parse(Console.ReadLine());

            if (inputOne % inputTwo == 0) { Console.WriteLine($"{inputOne} is a multiple of {inputTwo}"); }
            else { Console.WriteLine($"No {inputOne} is not a multiple of {inputTwo}"); }
        }
    }
}
