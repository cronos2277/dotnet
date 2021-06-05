using System;
namespace Fundamentos
{
    class WhileDoWhile
    {
        public static void Executar()
        {
            int i = 0;
            while (++i < 10){
                Console.WriteLine("WHILE: {0}",i);
            }

            Console.WriteLine("\n ---- \n");

            do
            {
                Console.WriteLine("DO-WHILE: {0}", i);
            } while (i-- > 0);
        }
    }
}
