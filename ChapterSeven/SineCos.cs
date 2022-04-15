using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSeven
{
    internal class SineCos
    {
        public static void RunTest()
        {
            Console.WriteLine("This is to get sin and cos of an angle");

            double angleInput = 0.0;
            angleInput = Input.GetPositiveDouble("Enter between a positive degree");
            
            Console.WriteLine($"Sin value of {angleInput} is: {Math.Sin(angleInput)}");
            Console.WriteLine($"Cos value of {angleInput} is: {Math.Cos(angleInput)}");

        }
    }
}
