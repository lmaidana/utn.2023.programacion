
namespace Ejercicio
{
    public class Product
    {
        public int Amount { get; set; }
        public float Price { get; set; }
        public string ProductName { get; set; }

        public Product()
        {

        }

        public void AddProduct()
        {
            
            Console.WriteLine("Insert Product Name");
            this.ProductName = Console.ReadLine();


            Console.WriteLine("Insert Price");
            string strPrice = Console.ReadLine();
            this.Price = float.Parse(strPrice);

            Console.WriteLine("Insert Quantity");
            string strAmount = Console.ReadLine();
            this.Amount = int.Parse(strAmount);

        }

        public void RemoveProduct()
        {
            this.Amount--;
        }

    }

}


