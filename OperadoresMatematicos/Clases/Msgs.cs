namespace OperadoresMatematicos.Clases
{
    internal class Msgs
    {
        public static void ErrorMsg(string v)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{v}");
            Console.ResetColor();
        }

        public static void WarningMsg(string v)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{v}");
            Console.ResetColor();
        }

        public static void SuccessMsg(string v)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"{v}");
            Console.ResetColor();
        }
    }
}
