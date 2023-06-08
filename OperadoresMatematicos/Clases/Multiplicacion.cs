using OperadoresMatematicos.Interfaces;

namespace OperadoresMatematicos.Clases
{
    internal class Multiplicacion : ICalculable
    {
        public Multiplicacion()
        {
        }

        public float Calcular(float a, float b)
        {
            return a * b;
        }
    }
}