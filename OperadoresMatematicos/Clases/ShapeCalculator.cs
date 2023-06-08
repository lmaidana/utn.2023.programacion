namespace OperadoresMatematicos.Clases
{
    internal class ShapeCalculator
    {
        public ShapeCalculator() { }

        public double Area(object shape)
        {
            if (shape is Triangulo)
            {
                return ((Triangulo)shape).Area();
            }
            else if (shape is Circulo)
            {
                return ((Circulo)shape).Area();
            }
            else { throw new Exception("No se conoce la forma"); }
        }

        public double Perimetro(object shape)
        {
            if (shape is Circulo)
            {
                return ((Circulo)shape).Perimetro();
            }
            else { throw new Exception("No se conoce la forma"); }
        }
    }
}
