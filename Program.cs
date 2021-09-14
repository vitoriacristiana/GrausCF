using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, convf;
            Console.Beep();
            Console.Clear();
            Console.Write("Digite o valor em ºC:");
            c = double.Parse(Console.ReadLine());
            convf = c * 1.8 + 3;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"/n{convf} ºF");
            Console.ResetColor();

        }
    }
}
