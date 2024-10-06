using System;
using Simple_Inventory_Management_System.Domain;

namespace Program
{
    public class MainClass
    {
        static public void Main()
        {
            int operation =0;
            Inventory inventory = new Inventory();

            do
            {
                Console.WriteLine($"What is the operation you want to do");
                Console.WriteLine($"1 for Adding a new product for the inventory");
                Console.WriteLine($"2 Displaying all products");
                Console.WriteLine($"3 To update a product");
                Console.WriteLine($"4 To delete a product");
                Console.WriteLine($"5 To search for a product");
                Console.WriteLine($"0 for Adding a new product for the inventory");
                operation = Console.Read() ;
                string name = string.Empty ;
                float price;
                int quantity;
                switch (operation)
                {
                    case 1:
                        string name = Console.ReadLine();
                        float price = (float)Convert.ToDouble(Console.ReadLine());
                        int quantity = Console.Read();
                        inventory.AddProduct(name, price, quantity);
                        break;
                    case 2:
                        inventory.Display();
                        break;
                    case 3:
                        string name = Console.ReadLine();
                        float price = (float)Convert.ToDouble(Console.ReadLine());
                        int quantity = Console.Read();
                }


            } while (operation != 0);

            inventory.AddProduct("Abood", 0, 10000);
            inventory.AddProduct("Amhad", -3000, 10000);
            inventory.Display();
        }
    }
}