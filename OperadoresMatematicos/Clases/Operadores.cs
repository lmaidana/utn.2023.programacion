namespace OperadoresMatematicos.Clases
{
    internal class Operadores
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static float Sumar(float a, float b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static float Restar(float a, float b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public static float Dividir(float a, float b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public static int Modulo(int a, int b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a % b;
        }

        public static float Modulo(float a, float b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a % b;
        }

        public static double Potencia(int a, int b)
        {
            return Math.Pow(a, b);
        }

        public static double Potencia(float a, float b)
        {
            return Math.Pow(a, b);
        }

        internal static float Promedio(float a, float b, float c)
        {
            return (a + b + c) / 3;
        }
    }
}
