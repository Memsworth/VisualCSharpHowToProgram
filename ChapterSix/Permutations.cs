using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualCSharpHowToProgram.ChapterFive;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class Permutations : Factorial
    {
        public static new void RunTest()
        {
            int totalObject = 0;
            int objectSelected = 0;

            while(true)
            {
                totalObject = Input.GetPositiveInteger("Enter total objects");
                objectSelected = Input.GetPositiveInteger("Enter objects selected");

                if(totalObject < objectSelected)
                {
                    Console.WriteLine("selected objects higher than total objects");
                    Console.WriteLine("Enter valid inputs");
                    continue;
                }

                break;
            }

            int permutationResult = GetFactorial(totalObject) / GetFactorial((totalObject - objectSelected));

            Console.WriteLine($"The result of {totalObject}P{objectSelected}: {permutationResult:N}");

        }
    }
}
