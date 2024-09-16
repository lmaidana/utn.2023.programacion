using OperadoresMatematicos.Interfaces;

namespace OperadoresMatematicos.Clases
{
    internal class Suma : ICalculable
    {
        public Suma()
        {
        }

        public float Calcular(float a, float b)
        {
            return a + b;
        }
    }
}