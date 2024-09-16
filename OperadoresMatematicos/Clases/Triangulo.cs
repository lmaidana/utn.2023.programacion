
namespace OperadoresMatematicos.Clases
{
    internal class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo(double widht, double altura)
        {
            Base = widht;
            Altura = altura;
        }

        public double Area()
        {
            return Base * Altura / 2;
        }
    }
}
