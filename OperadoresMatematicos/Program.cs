using ConsoleTables;
using OperadoresMatematicos.Clases;

namespace OperadoresMatematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                showOptionsTable();

                var option = Console.ReadLine();

                while (!Validator.IsValidOption(option))
                {
                    Msgs.WarningMsg("Opcion incorrecta!");
                    Console.ResetColor();
                    showOptionsTable();
                    option = Console.ReadLine();
                }
                Console.Clear();
                if (option.Contains('s'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2)) 
                    {
                        int result = Operadores.Sumar(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operadores.Sumar(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('r'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        int result = Operadores.Restar(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operadores.Restar(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('m'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        int result = Operadores.Multiplicar(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operadores.Multiplicar(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('d'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        try
                        {
                            int result = Operadores.Dividir(intInput1, intInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                        }
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        try
                        {
                            float result = Operadores.Dividir(floatInput1, floatInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                        }
                    }
                }

                if (option.Contains('f'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        try
                        {
                            int result = Operadores.Modulo(intInput1, intInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                        }
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        try
                        {
                            float result = Operadores.Modulo(floatInput1, floatInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                        }
                    }
                }

                if (option.Contains('p'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        double result = Operadores.Potencia(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        double result = Operadores.Potencia(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('x'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();
                    var input3 = Validator.GetInput();

                    float.TryParse(input1, out float floatInput1);
                    float.TryParse(input2, out float floatInput2);
                    float.TryParse(input3, out float floatInput3);

                    float result = Operadores.Promedio(floatInput1, floatInput2, floatInput3);
                    Msgs.SuccessMsg("Resultado: " + result +"\n");
                }

                if (option.Contains('k'))
                {
                    Console.WriteLine("\nEliga forma: t- Triangulo | c- Circulo");
                    var shapeOption= Console.ReadLine();

                    while (!Validator.IsValidOption(shapeOption))
                    {
                        Msgs.WarningMsg("Opcion incorrecta, t- Triangulo | c- Circulo\n");
                        shapeOption = Console.ReadLine();
                    }

                    if (shapeOption.Contains('c'))
                    {
                        Console.WriteLine("\nArea o perimetro: a- Area | p- perimetro");
                        var shapeCalculatorOption = Console.ReadLine();
                        Console.WriteLine("Ingrese radio");
                        var input = Console.ReadLine();
                        float radio = Validator.GetShapesInputs(input);
                        Circulo circulo = new Circulo(radio);
                        if (shapeCalculatorOption == "a")
                        {
                            Msgs.SuccessMsg("El area del circulo es: "+ circulo.Area()+"\n");
                        }
                        else if (shapeCalculatorOption == "p") 
                        {
                            Msgs.SuccessMsg("El perimetro del circulo es: " + circulo.Perimetro()+"\n");
                        }
                        else
                        {
                            Msgs.ErrorMsg("Solo podemos calcular area y perimetro, vuelva a intentar");
                        }
                    }
                    else if (shapeOption.Contains('t'))
                    {
                        Console.WriteLine("Ingrese base del triangulo:");
                        var input = Console.ReadLine();
                        float baseTriangulo = Validator.GetShapesInputs(input);
                        Console.WriteLine("Ingrese altura del triangulo:");
                        var input2 = Console.ReadLine();
                        float alturaTriangulo = Validator.GetShapesInputs(input2);

                        Triangulo triangulo = new(baseTriangulo, alturaTriangulo);
                        Msgs.SuccessMsg("El area del triangulo es: "+ triangulo.Area()+"\n");

                    }
                }
                if (option.Contains('o'))
                {
                    Console.WriteLine("Grados celsius a convertir:");
                    var input1 = Validator.GetInput();
                    float.TryParse(input1, out float grados);
                    float fh = grados * 9 / 5 + 32;
                    Msgs.SuccessMsg("Grados en farenheit: "+ fh+"\n");
                }
                if (option.Contains('y'))
                {
                    var input1 = Validator.GetInput();
                    showOperatorsTable();
                    var operador = Console.ReadLine();
                    operador = Validator.IsValidOperator(operador);
                    var input2 = Validator.GetInput();
                    float.TryParse(input1, out float floatInput1);
                    float.TryParse(input2, out float floatInput2);

                    Calculadora c = new Calculadora(floatInput1, floatInput2);

                    if (operador == "+")
                    {
                        var resultado = c.Calcular(new Suma());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "-")
                    {
                        var resultado = c.Calcular(new Resta());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "/")
                    {
                        var resultado = c.Calcular(new Division());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "#")
                    {
                        var resultado = c.Calcular(new Multiplicacion());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }

                }

                Console.ResetColor();
            }
        }

        private static void showOptionsTable()
        {
            Console.WriteLine("\nBienvenido!\n");
            ConsoleTable consoleTable = new("Que operacion quiere realizar ?");
            consoleTable.AddRow("s - Suma");
            consoleTable.AddRow("r- Resta");
            consoleTable.AddRow("m- Multiplicacion");
            consoleTable.AddRow("f- Modulo");
            consoleTable.AddRow("p- Potencia");
            consoleTable.AddRow("x- Promedio");
            consoleTable.AddRow("k- CalculadoraDeFormas");
            consoleTable.AddRow("y- CalculadoraSOLID");
            consoleTable.Write(Format.Alternative);
        }
        private static void showOperatorsTable()
        {
            ConsoleTable consoleTable = new("Que operacion quiere realizar ?");
            consoleTable.AddRow("+ Suma");
            consoleTable.AddRow("- Resta");
            consoleTable.AddRow("# Multiplicacion");
            consoleTable.AddRow("/ Division");
            consoleTable.Write(Format.Alternative);
        }
    }
}