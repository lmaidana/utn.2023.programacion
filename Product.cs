// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleInventory
{
    /// <summary>
    /// This class set products atributes.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string ProductName { get; set; }
    }
}