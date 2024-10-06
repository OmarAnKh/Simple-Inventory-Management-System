using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System.Domain
{
    public class Product
    {
        public string Name=string.Empty;
        public float Price;
        public int Quantity;

        public Product(string name, float price) : this(name,price,0)
        {

        }
        public Product(string name,float price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public Product(Product product)
        { 
            this.Name=product.Name;
            this.Price = product.Price;
            this.Quantity = product.Quantity;
        }



    }
}
