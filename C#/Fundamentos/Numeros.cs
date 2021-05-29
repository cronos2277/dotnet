using System;
namespace Fundamentos
{
    class Numeros
    {
        public static void Executar()
        {
            int numero = 0;
            Console.WriteLine(numero);

            //Byte
            Console.WriteLine($"Byte, Valor Mínimo: {byte.MinValue}, valor Máximo {byte.MaxValue}");

            //Signal Byte
            Console.WriteLine($"SByte, Valor Mínimo: {sbyte.MinValue}, valor Máximo {sbyte.MaxValue}");

            //Short
            Console.WriteLine($"Short, valor mínimo: {short.MinValue}, valor máximo: {short.MaxValue}");

            //Int
            Console.WriteLine($"Integer, valor mínimo: {int.MinValue}, valor máximo: {int.MaxValue}");

            //Uint
            Console.WriteLine($"Uint, valor mínimo: {uint.MinValue}, valor máximo: {uint.MaxValue}");

            //Long
            Console.WriteLine($"Long, valor mínimo: {long.MinValue}, valor máximo {long.MaxValue}");

            //ULong
            Console.WriteLine($"ULong, valor mínimo: {ulong.MinValue}, valor máximo {ulong.MaxValue}");

            //Float
            Console.WriteLine($"Float, valor mínimo: {float.MinValue}, valor máximo {float.MaxValue}");

            //Double
            Console.WriteLine($"Double, valor mínimo: {double.MinValue}, valor máximo {double.MaxValue}");

            //Decimal
            Console.WriteLine($"Decimal, valor mínimo: {decimal.MinValue}, valor máximo {decimal.MaxValue}");
        }
    }
}
