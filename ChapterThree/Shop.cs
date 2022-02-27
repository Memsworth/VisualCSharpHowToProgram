using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterThree
{
    internal class Shop
    {
        public static void Shopping()
        {
            const float discount = 0.10f;
            float itemOne = 0.0f;
            float itemTwo = 0.0f;
            float itemThree =0.0f;

            Console.Write("Enter price for item one: ");
            itemOne = float.Parse(Console.ReadLine());

            Console.Write("Enter price for the item two: ");
            itemTwo = float.Parse(Console.ReadLine());

            Console.Write("Enter price for the item three: ");
            itemThree = float.Parse(Console.ReadLine());


            Console.WriteLine($"\nprice of item one is: {itemOne} & after applying {discount*100}% discount");
            itemOne = itemOne - (itemOne * discount);
            Console.WriteLine($"New price of item one is: {itemOne}");

            
            Console.WriteLine($"\nprice of item two is: {itemTwo} & after applying {discount * 100}% discount");
            itemTwo = itemTwo - (itemTwo * discount);
            Console.WriteLine($"New price of item one is: {itemTwo}");


            Console.WriteLine($"\nprice of item three is: {itemThree} & after applying {discount * 100}% discount");
            itemThree = itemThree - (itemThree * discount);
            Console.WriteLine($"New price of item three is: {itemThree}");

            Console.WriteLine($"\nSum of the three items are: {(itemOne+itemThree+itemTwo):N}");
        }
    }
}
