using System;
namespace Fundamentos
{
    class Conversao
    {
        public static void Executar()
        {
            Console.WriteLine("Digite alguma coisa:");
            string resultado = Console.ReadLine();
            Console.WriteLine("Texto digitado:"+resultado);

            Console.WriteLine("Dando cast no valor 10.3 para inteiro: {0}",((int) 10.3));
            Console.WriteLine(
                    "Convertendo texto para numero: Com Ponto para decimal: '{0}', com virgula: '{1}'",
                        double.Parse("22.657"), 
                        double.Parse("22,657")
            );
        }
    }
}
