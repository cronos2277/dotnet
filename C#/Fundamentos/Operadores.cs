using System;

namespace Fundamentos
{
    /// <summary>
    ///     <operadores>
    ///         Exemplo de documentação no C#
    ///     </operadores>
    /// </summary>
    class Operadores
    {
        public static void Executar()
        {
            int a = 0; int b = 0;
            Console.WriteLine(++a);
            Console.WriteLine(b--);
            Console.WriteLine( (1+1) / (2*1) - 1);

            Console.WriteLine("Verdadeiro e Verdadeiro: {0}", true && true);
            Console.WriteLine("Falso ou Falso: {0}", false || false);

            //XOR
            Console.WriteLine("\n XOR \n");
            Console.WriteLine("Verdadeiro XOR Verdadeiro: {0}", true ^ true);
            Console.WriteLine("Verdadeiro XOR Falso: {0}", true ^ false);
            Console.WriteLine("Falso XOR Verdadeiro: {0}", false ^ true);
            Console.WriteLine("Falso XOR Falso: {0}", false ^ false);
        }
    }
}
