using OperadoresMatematicos.Interfaces;

namespace OperadoresMatematicos.Clases
{
    internal class Resta : ICalculable
    {
        public Resta()
        {
        }

        public float Calcular(float a, float b)
        {
            return a - b;
        }
    }
}