using System;

namespace Fundamentos
{
    class ForForEach
    {
        public static void Executar()
        {
            for (int i = 0;i <= 10; i++)
            {
                Console.WriteLine("For Normal: {0}",i);           
            }
            string texto = "Olá Mundo!";
            Console.WriteLine("\nPalavra: {0}\n",texto);
            foreach(char letra in texto)
            {
                Console.WriteLine("Caracter: {0}",letra);
            }           
        }
    }
}
