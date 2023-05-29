// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleInventory
{
    /// <summary>
    /// Main class, program.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Inventory inventory = new ();

            while (true)
            {
                Console.WriteLine("\nWhich action do you want to do?  a- Add/Update Product | d- Delete/Remove Product | s- Show Product List");
                var option = Console.ReadLine();

                while (IsValidOption(option) == false)
                {
                    Console.WriteLine("Wrong input, which action?   a- Add/Update Product | d- Delete/Remove Product | s- Show Product List");
                    option = Console.ReadLine();
                }

                if (option.Contains('a'))
                {
                    inventory.AddProduct(inventory);
                }

                if (option.Contains('d'))
                {
                    inventory.RemoveProduct();
                }

                if (option.Contains('s'))
                {
                    inventory.ShowAllProducts(inventory);
                }
            }
        }

        private static bool IsValidOption(string option)
        {
            string option1 = "a";
            string option2 = "d";
            string option3 = "s";

            if (option.Length > 1 || string.IsNullOrEmpty(option))
            {
                return false;
            }

            if (option.Equals(option1) || option.Equals(option2) || option.Equals(option3)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
