using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_ShopMenu
{
    internal class ProductList
    {
        private List<Product> list;

        public ProductList() { list = new List<Product>(); }

        public List<Product> List { get { return list; } }

        public void InputProduct()
        {
            Console.WriteLine("Input Product:");
            string Continue = "Y";
            do
            {
                Product product = new Product();
                product.Input();
                list.Add(product);
                Console.WriteLine("Add Product Success!");
                Console.Write("Want continue add product (Y/N): ");
                Continue = Console.ReadLine();
            } while (Continue == "Y" || Continue == "y");
        }

        public void DisplayProduct()
        {
            Product product = new Product();
            Console.WriteLine("Product ID     Product Name     Price");
            product.Display();
        }

        public int IndexOf(string ID)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].setID == ID)
                {
                    return i;
                }
            }

            return -1;
        }

        public void DeleteByID()
        {
            string ID;
            Console.WriteLine("Delete product by ID:");
            Console.Write("Enter ID want to delete: ");
            ID = Console.ReadLine();
            int index = IndexOf(ID);
            if (index < 0)
                Console.WriteLine("Not found this ID!");
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("This product have been deleted!");
            }
        }
    }
}
