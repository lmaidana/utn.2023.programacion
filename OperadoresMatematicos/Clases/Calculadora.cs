using OperadoresMatematicos.Interfaces;

namespace OperadoresMatematicos.Clases
{
    internal class Calculadora
    {
        private float PrimerInput { get; set; }
        private float SegundoInput { get; set; }

        // Funciona únicamente con dos argumentos, luego agregar array.
        public Calculadora(float primerInput, float segundoInput)
        {
            PrimerInput = primerInput;
            SegundoInput = segundoInput;
        }

        internal float Calcular(ICalculable operador)
        {
            return operador.Calcular(PrimerInput, SegundoInput);
        }

    }
}
