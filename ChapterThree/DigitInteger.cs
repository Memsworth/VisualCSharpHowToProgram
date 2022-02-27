using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class DigitInteger
    {
        public static void Solution()
        {
            int divisor = 1;
            int numberInput = 0;
            int reverseNumber = 0;

            while(true)
            {
                Console.Write("Enter a five digit int: ");
                bool checker = int.TryParse(Console.ReadLine(), out numberInput);
                if(numberInput < 100000 && numberInput>9999 && checker) { break; }
            }
            int originalNumber = numberInput;
            while(numberInput>0)
            {
                int mod = numberInput % 10;
                reverseNumber = reverseNumber * 10 + mod;
                numberInput /= 10;
            }

            while(reverseNumber>0)
            {
                int mod = reverseNumber % 10;
                Console.Write($"   {mod}   ");
                reverseNumber /= 10;
            }

            Console.WriteLine($"\nOriginal number: {originalNumber}");
        }
    }
}
