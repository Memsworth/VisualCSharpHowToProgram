using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class SmallorLarge
    {
        public static void Solution()
        {
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;

            Console.Write("Enter int: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter int: ");
            numberTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter int: ");
            numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers are: {numberOne}, {numberTwo}, {numberThree}");
            Console.WriteLine($"Sum: {numberOne+numberTwo+numberThree}");
            Console.WriteLine($"average: {(numberOne+numberTwo+numberThree)/3}");
            Console.WriteLine($"Product: {numberOne*numberTwo*numberThree}");

            int large = numberOne;
            int small = numberOne;

            if(large < numberTwo) { large = numberTwo; }
            else if (large < numberThree) { large = numberThree; }

            if (small > numberTwo) { small = numberTwo; }
            else if (small > numberThree) { small = numberThree; }

            Console.WriteLine($"Smallest number: {small}");
            Console.WriteLine($"Largest number: {large}");
        }
    }
}
