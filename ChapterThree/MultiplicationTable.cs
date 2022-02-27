using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class MultiplicationTable
    {
        public static void Solution()
        {
            int inputNumber = 0;
            while(true)
            {
                Console.Write("Input a number: ");
                bool checker = int.TryParse(Console.ReadLine(), out inputNumber);
                if(checker && inputNumber > 0) { break; }
            }

            Console.WriteLine("The Table is:- ");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{inputNumber}    X    {i}   =    {inputNumber*i}");
            }
        }
    }
}
