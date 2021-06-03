using System;

namespace Fundamentos
{
    class DesvioCondicional
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            if(numero == 0)
            {
                Console.WriteLine("O numero é zero");
            }
            else if(numero > 0)
            {
                Console.WriteLine("Numero maior que zero");
            }
            else
            {
                Console.WriteLine("Numero menor que zero");
            }

            switch (numero)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Número entre 1,2 ou 3");
                    break;
                case 4: {
                        Console.WriteLine("Numero igual a 4");
                        Console.WriteLine("Segunda instrução.");
                        break;
                    }                
                default: Console.WriteLine("Número fora do intervalo 1,4");break ;

            }
        }
    }
}
