using System;

namespace Fundamentos
{
    class Textos
    {
        public static void Executar()
        {
            //Char
            char letra = 'a';
            Console.WriteLine(letra);

            //String
            string texto = "TEXTO - 1";
            Console.WriteLine(texto);

            //Interpolando em sequencia
            Console.WriteLine("Valor 1: {0}, valor 2: {1}, valor 3: {2}, etc...",1,2,3);

            //Interpolando com variaveis.
            Console.WriteLine($"Valor da variável texto = {texto}");
        }
    }
}
