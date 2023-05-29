// <copyright file="Validator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleInventory
{
    /// <summary>
    /// This class is for validate inputs.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Validator"/> class.
        /// </summary>
        public Validator()
        {
        }

        /// <summary>
        /// Check products sintax.
        /// </summary>
        /// <param name="product">productName.</param>
        /// <returns>boolean.</returns>
        public bool IsValidProduct(string? product)
        {
            bool isNumber = int.TryParse(product, out int valueInt);
            bool isFloat = float.TryParse(product, out float valueFloat);

            if (string.IsNullOrEmpty(product) || isNumber || isFloat)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check valid price.
        /// </summary>
        /// <param name="strPrice"> price.</param>
        /// <returns>boolean.</returns>
        public bool IsValidPrice(string? strPrice)
        {
            bool isNumber = int.TryParse(strPrice, out int valueInt);
            bool isFloat = float.TryParse(strPrice, out float valueFloat);

            if (string.IsNullOrEmpty(strPrice) || (!isNumber && !isFloat) || (valueInt < 0 || valueFloat < 0))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if amount is valid.
        /// </summary>
        /// <param name="strAmount"> amount.</param>
        /// <returns>boolean.</returns>
        public bool IsValidAmount(string? strAmount)
        {
            bool isInteger = int.TryParse(strAmount, out int valueInt);

            if (!isInteger || valueInt < 0)
            {
                return false;
            }

            return true;
        }
    }
}
