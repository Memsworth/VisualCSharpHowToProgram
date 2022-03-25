using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class Quadrilateral
    {
        public static void RunTest()
        {
            int valOne = Input.GetPositiveInteger("Enter angle one");
            int valTwo = Input.GetPositiveInteger("Enter angle two");
            int valThree = Input.GetPositiveInteger("Enter angle three");
            int valFour = Input.GetPositiveInteger("Enter angle four");

            int quadAngle = valOne + valTwo + valThree + valFour;

            if(quadAngle == 360)
            {
                Console.WriteLine("This is a quadrilateral");
            }

            else
            {
                Console.WriteLine("This is not a quadrital angle");
            }
        }
    }
}
