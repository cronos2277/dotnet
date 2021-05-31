using System;
namespace Fundamentos
{
    class ParseTexto
    {
        public static void Executar()
        {
            string texto_a = (10.33847).ToString("#.##");
            Console.WriteLine(texto_a);

            double.TryParse("a", out double numero);
            Console.WriteLine($"Numero convertido: {0}",numero);
        }
    }
}
