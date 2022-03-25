using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class BinaryToDecimal
    {
        public static void RunTest()
        {
            int binaryInput = GetBinary();
            int decimalOutput = ConvertToDecimal(binaryInput);
            Console.WriteLine(decimalOutput);

        }

        private static int ConvertToDecimal(int binaryInput)
        {
            int decimalValue = 0;

            for (int i = 0; binaryInput != 0; i++)
            {
                int remainder = binaryInput % 10;
                decimalValue += remainder * (int)Math.Pow(2, i);
                binaryInput /= 10;
            }

            return decimalValue;
        }

        private static int GetBinary()
        {
            int binaryInput = 0;

            while (true)
            {
                binaryInput = Input.GetPositiveInteger("Enter a binray number");
                
                string check = Convert.ToString(binaryInput);
                bool isBinary = true;
                
                for (int i = 0; i < check.Length; i++)
                {
                    isBinary = isBinary && (check[i] == '1' || check[i] == '0');
                }

                if (isBinary) { break; }
                else { Console.WriteLine("Enter a correct binary number"); }
            }
            
            return binaryInput;
        }
    }
}
