using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSix
{
    internal class CalculatingSales
    {
        public static void RunTest()
        {
            decimal[] products = { 2.98m, 4.50m, 9.98m };

            decimal totalCost = 0.0m;
            int userInput = 0;
            do
            {
                ShowMenu();
                userInput = Input.GetNumber("Enter your input");
                switch (userInput)
                {
                    case 1:
                        ShowInventory(products);
                        totalCost += AddProduct(products);
                        break;
                    case 2:
                        Console.WriteLine($"Total cost in cart: {totalCost:C}");
                        break;
                    default:
                        break;
                }

            } while (userInput != 0);

            Console.WriteLine($"Total amount to pay: {totalCost:C}");
        }


        private static decimal AddProduct(decimal[] products)
        {
            decimal cost = 0.0m;

            while(true)
            {
                try
                {
                    int productInput = Input.GetNumberInRange("Enter product you want to buy", 0, 4);
                    int amountInput = Input.GetPositiveInteger("Enter amount");
                    cost += products[productInput-1] * amountInput;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input no product");
                    throw;
                }
            }

            return cost;
        }
        private static void ShowMenu()
        {
            Console.WriteLine("1. Add products to cart");
            Console.WriteLine("2. Show total cart cost");
            Console.WriteLine("0. Exit");
        }


        private static void ShowInventory(decimal[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"product {i+1}: {products[i]:C}");
            }
        }
    }
}
