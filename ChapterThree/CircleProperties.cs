using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class CircleProperties
    {
        public static void Solution()
        {
            int radius = 0;
            bool checker = true;

            do
            {
                Console.Write("Enter circle raidus: ");
                checker = int.TryParse(Console.ReadLine(), out radius);
            } while (radius <= 0 && checker);

            Console.WriteLine($"Diameter: {(2*radius)}");
            Console.WriteLine($"Circumference: {(2*Math.PI*radius):N}");
            Console.WriteLine($"Area: {(Math.PI*Math.Pow(radius, 2)):N}CM");
        }
    }
}
