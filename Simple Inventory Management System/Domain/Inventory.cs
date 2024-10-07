using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Simple_Inventory_Management_System.Domain
{
    public class Inventory
    {
        public List<Product> Products {  get; private set; }

        public Inventory() { 
            Products = new List<Product>();
        }

        public void Display(List<Product> productsList)
        {
            foreach (var item in productsList) { 
                Console.WriteLine($"The name of the product {item.Name}, the price = {item.Price},and the quantity = {item.Quantity}");
            }
        }

        public void AddProduct(string name, float price, int quantity) {
            Product temp=new Product(name, price, quantity);
            Products.Add(temp);
        }

        private int ReturnIndex(string name) {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name == name)
                {
                    return i; 
                }
            }

            return -1;

        }

        public void UpdateProduct(string name, float price, int quantity,string newName) {
            int index = ReturnIndex(name);
            if (index == -1)
                return;
            Products[index].Name = newName;
            Products[index].Price = price;
            Products[index].Quantity = quantity;
        }
        public void RemoveProduct(string name) {
            int index = ReturnIndex(name);
            if (index == -1)
                return;
            Products.RemoveAt(ReturnIndex(name));
        }

        

    }
}
