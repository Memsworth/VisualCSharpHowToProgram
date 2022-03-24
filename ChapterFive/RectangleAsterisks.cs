using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFive
{
    internal class RectangleAsterisks
    {
        public static void RunTest()
        {
            const int recHeightMax = 15;
            const int recWidthMax = 10;
            int recHeight = Input.GetPositiveInteger("Enter height between 1 and 15");
            int recWidth = Input.GetPositiveInteger("Enter width between 1 and 10");

            if(recHeight > recHeightMax) {  recHeight = recHeightMax; }
            if(recWidth > recWidthMax) { recWidth = recWidthMax; }

            for (int i = 0; i < recHeight; i++)
            {
                for (int j = 0; j < recWidth; j++)
                {

                }
            }
        }
    }
}
