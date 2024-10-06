using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Simple_Inventory_Management_System.Domain
{
    public class Inventory
    {
        private List<Product> Products;

        public Inventory() { 
            Products = new List<Product>();
        }
        public void Display()
        {
            foreach (var item in Products) { 
                Console.WriteLine($"The name of the product {item.Name}, the price = {item.Price},and the quantity = {item.Quantity}");
            }
        }
        public void AddProduct(string name, float price, int quantity) {
            Product temp=new Product(name, price, quantity);
            Products.Add(temp);
        }

        private int returnIndex(string name) {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name == name)
                {
                    return i; 
                }
            }

            return -1;

        }

        public void RemoveProduct(string name) {
            Products.RemoveAt(returnIndex(name));
        }

    }
}
