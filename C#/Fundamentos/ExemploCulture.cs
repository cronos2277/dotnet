using System;
using System.Globalization;

namespace Fundamentos
{
    class ExemploCulture
    {
        public static void Executar()
        {
            CultureInfo americano = new CultureInfo("en-US");
            double numeroAmericano = Convert.ToDouble("10.25",americano);

            CultureInfo brasileiro = new CultureInfo("pt-BR");
            double numeroBrasileiro = Convert.ToDouble("10,25", brasileiro);

            Console.WriteLine($"Numero americano convertido: {numeroAmericano} Brasileiro convertido: {numeroBrasileiro} os valores são iguais? {numeroAmericano == numeroBrasileiro}");

            double numeroPadrao = Convert.ToDouble("10.25", CultureInfo.InvariantCulture);
            Console.WriteLine("Numero Padrao: "+numeroPadrao);            
        }
    }
}
