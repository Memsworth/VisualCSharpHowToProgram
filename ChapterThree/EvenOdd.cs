using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class EvenOdd
    {
        public static void Solution()
        {
            Console.Write("Enter an int: ");
            int numberInput = int.Parse(Console.ReadLine());

            if (numberInput % 2 == 0) { Console.WriteLine("This number is even"); }
            else { Console.WriteLine("This number is odd"); }
        }
    }
}
