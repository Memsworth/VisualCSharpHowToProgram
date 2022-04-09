using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class MultiplesFive
    {
        public static void RunTest()
        {
            int correctCounter = 0;
            int wrongCounter = 0;

            while (true)
            {

                int userInput = Input.GetNumber("Enter a valid input");
                if (userInput <= 0) { break; }
                if (userInput % 5 == 0) 
                {
                    Console.WriteLine("Valid input");
                    correctCounter++;
                }

                else if (userInput % 5 != 0)
                {
                    Console.WriteLine("Invalid input");
                    wrongCounter++;
                }


                Console.WriteLine($"valid input: {correctCounter}");
                Console.WriteLine($"invalid input: {wrongCounter}");
            }
        }
    }
}
