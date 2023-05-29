// <copyright file="Inventory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleInventory
{
    using ConsoleTables;

    /// <summary>
    /// Inventory class.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Contains a list of Proucts.
        /// </summary>
        public List<Product> AllProducts = new List<Product>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory"/> class.
        /// </summary>
        public Inventory()
        {
        }

        /// <summary>
        /// Check if input product exists.
        /// </summary>
        /// <param name="strProd"> Input product. </param> Input.
        /// <param name="inventory"> Inventory. </param>
        /// <returns> Returns index of the product in the inventory, otherwise returns -1. </returns>
        public static int ProductExists(string? strProd, Inventory inventory)
        {
            foreach (Product item in inventory.AllProducts)
            {
                if (item.ProductName == strProd)
                {
                    return inventory.AllProducts.IndexOf(item);
                }
            }

            return -1;
        }

        /// <summary>
        /// This method add a new product.
        /// </summary>
        /// <param name="inventory"> Inventory.</param>
        internal void AddProduct(Inventory inventory)
        {
            Validator validator = new ();
            Product product = new ();

            Console.WriteLine("Insert Product Name");
            string strProd = Console.ReadLine();
            while (!validator.IsValidProduct(strProd))
            {
                WarningMsg("Wrong! Product Name must be a string, try again");
                Console.WriteLine("\nPlease retry");
                strProd = Console.ReadLine();
            }

            product.ProductName = strProd;

            Console.WriteLine("Insert Price");
            string strPrice = Console.ReadLine();
            while (!validator.IsValidPrice(strPrice))
            {
                WarningMsg("Wrong! Product Price must only have positives numbers, try again");
                Console.WriteLine("\nPlease retry");
                strPrice = Console.ReadLine();
            }

            product.Price = float.Parse(strPrice);

            Console.WriteLine("Insert Quantity");
            string strAmount = Console.ReadLine();
            while (!validator.IsValidAmount(strAmount))
            {
                WarningMsg("Wrong! Product Amount must only have positive integers, try again");
                Console.WriteLine("\nPlease retry");
                strAmount = Console.ReadLine();
            }

            product.Amount = int.Parse(strAmount);

            // If product exists, add amount and update price.
            int position = ProductExists(product.ProductName, inventory);
            if (position != -1)
            {
                inventory.AllProducts[position].Amount += product.Amount;
                inventory.AllProducts[position].Price = product.Price;
                SuccessMsg("Amount and price updated");
            }
            else
            {
                this.AllProducts.Add(product);
                SuccessMsg("Product added successfully");
            }
        }

        /// <summary>
        /// This method removes an existing product or print in console if not exists.
        /// </summary>
        internal void RemoveProduct()
        {
            Validator validator = new ();

            Console.WriteLine("Which product do you want to remove?");
            string strProd = Console.ReadLine();

            while (!validator.IsValidProduct(strProd))
            {
                WarningMsg("Wrong! Product Name must be a string, try again");
                Console.WriteLine("\nPlease retry");
                strProd = Console.ReadLine();
            }

            // If product exists, remove amount or delete.
            int position = ProductExists(strProd, this);
            if (position >= 0)
            {
                Console.WriteLine("Insert amount to remove:");
                var amountToRemove = Console.ReadLine();
                while (!validator.IsValidAmount(amountToRemove))
                {
                    WarningMsg("Amount can only be a positive integer");
                    Console.WriteLine("\nPlease retry");
                    amountToRemove = Console.ReadLine();
                }

                int amountToRemoveValidated = int.Parse(amountToRemove);

                if (this.AllProducts[position].Amount == amountToRemoveValidated)
                {
                    this.AllProducts.RemoveAt(position);
                    SuccessMsg("Removed successfully");
                }
                else if (this.AllProducts[position].Amount > amountToRemoveValidated)
                {
                    this.AllProducts[position].Amount -= amountToRemoveValidated;
                    SuccessMsg("Quantity removed successfully");
                }
                else
                {
                    WarningMsg("Amount cannot be negative, please check inventory");
                }
            }
            else
            {
                ErrorMsg("Error, product not found!");
            }
        }

        /// <summary>
        /// Shows all products on inventory.
        /// </summary>
        /// <param name="inventory"> inventory.</param>
        internal void ShowAllProducts(Inventory inventory)
        {
            if (inventory.AllProducts.Count > 0)
            {
                Console.WriteLine("\nAll products:\n");
                ConsoleTable consoleTable = new ("Product name", "Price", "Amount");

                foreach (var item in inventory.AllProducts)
                {
                    consoleTable.AddRow(item.ProductName, item.Price, item.Amount);
                }

                consoleTable.Write(Format.Alternative);
            }
            else
            {
                Console.WriteLine("\nEmpty Inventory!\n");
            }
        }

        private static void ErrorMsg(string v)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{v}");
            Console.ResetColor();
        }

        private static void WarningMsg(string v)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{v}");
            Console.ResetColor();
        }

        private static void SuccessMsg(string v)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"{v}");
            Console.ResetColor();
        }

    }
}
