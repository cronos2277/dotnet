using System;

namespace Fundamentos
{
    class BreakContinue
    {
        public static void Executar()
        {
            for(int i = 1; true; i++)
            {                
                if(i % 10 == 0)
                {
                    Console.WriteLine("\n");
                    continue;
                }

                Console.Write(i + " ");

                if (i == 99)
                {
                    break;
                }
               
            }
        }
    }
}
