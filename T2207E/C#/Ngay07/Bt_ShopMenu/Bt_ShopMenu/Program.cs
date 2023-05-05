using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_ShopMenu
{
    internal class Program
    {
        public static int Menu()
        {
            int choice;

            Console.WriteLine("------ MENU ------");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by ID");
            Console.WriteLine("4. Exit");
            do
            {
                Console.Write("Enter your choice (1-4): ");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 4);

            return choice;
        }

        static void Main(string[] args)
        {
            int choice;
            ProductList productList = new ProductList();

            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        productList.InputProduct();
                        break;
                    case 2:
                        productList.DisplayProduct();
                        break;
                    case 3:
                        productList.DeleteByID();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please enter 1-4!");
                        break;
                }
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
            } while (choice != 4);
        }
    }
}
