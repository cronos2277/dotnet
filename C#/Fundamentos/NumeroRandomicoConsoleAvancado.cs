using System;

namespace Fundamentos
{
    class NumeroRandomicoConsoleAvancado
    {
        public static void Executar()
        {
            Random randomico = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(randomico.Next(1,100));
            Console.WriteLine(randomico.NextDouble());
        }
    }
}
