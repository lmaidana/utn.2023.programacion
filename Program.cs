    namespace Ejercicio
{
    class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product();
            product.AddProduct();
            Console.WriteLine("Producto al agregarlo: "+product.ProductName+"|"+product.Price + "|" +product.Amount);
            product.RemoveProduct();
            product.RemoveProduct();
            Console.WriteLine("Producto luego de quitar dos unidades: " + product.ProductName + "|" + product.Price + "|" + product.Amount);
        }
    }
}

