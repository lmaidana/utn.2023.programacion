namespace OperadoresMatematicos.Clases
{
    internal class Circulo
    {
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double Area()
        {
            return Math.PI * (Radio * Radio);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

    }
}
