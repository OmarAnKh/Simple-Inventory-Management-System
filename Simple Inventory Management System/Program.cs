﻿using System;
using Simple_Inventory_Management_System.Domain;

namespace Program
{

    public class MainClass
    {
        static int operation = 0;
        static void printMenu()
        {
            do
            {
                Console.WriteLine($"What is the operation you want to do");
                Console.WriteLine($"1 for Adding a new product for the inventory");
                Console.WriteLine($"2 Displaying all products");
                Console.WriteLine($"3 To update a product");
                Console.WriteLine($"4 To delete a product");
                Console.WriteLine($"5 To search for a product");
                Console.WriteLine($"0 for Adding a new product for the inventory");
                int.TryParse(Console.ReadLine(), out operation);
            } while (operation > 5 || operation < 0);


        }
        static List<string> getInfo()
        {
            string name = Console.ReadLine().Trim();
            string price = Console.ReadLine();
            string quantity = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add(name);
            list.Add(price);
            list.Add(quantity);
            return list;
        }

        static void addProduct(Inventory inventory)
        {
            List<string> list = getInfo();
            inventory.AddProduct(list[0], (float)Convert.ToDouble(list[1]), Convert.ToInt32(list[2]));
        }

        

        static public void Main()
        {
            Inventory inventory = new Inventory();
            
            do
            {
                printMenu();

                switch (operation)
                {
                    case 1:
                        addProduct(inventory);
                        break;
                    case 2:
                        inventory.Display(inventory.Products);
                        break;
                    case 3:
                        List<string> list = getInfo();  
                        string newName = Console.ReadLine().Trim();
                        inventory.UpdateProduct(list[0], (float)Convert.ToDouble(list[1]), Convert.ToInt32(list[2]), newName);
                        break;
                    case 4:
                        string productName = Console.ReadLine().Trim();
                        inventory.RemoveProduct(productName);
                        break;

                    case 5:

                        break;
                }


            } while (operation != 0);
        }
    }
}