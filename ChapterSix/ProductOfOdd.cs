using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class ProductOfOdd
    {
        public static void RunTest()
        {
            Console.WriteLine("This will calculate product of odd ints from 1 to n");
            int n = Input.GetPositiveInteger("Enter a postitive number");
            int productResult = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) { continue; }
                productResult *= i;
            }

            Console.WriteLine($"from 1 to {n}, product of odd number: {productResult}"); 
        }
    }
}
