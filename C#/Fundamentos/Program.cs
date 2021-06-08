using System;
using System.Collections.Generic;

namespace Fundamentos
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Ola Mundo - Fundamentos", Primeiro.Executar},
                {"Booleana e inferrência de tipos", Booleanos.Executar},
                {"Strings e Textos", Textos.Executar},
                {"Números", Numeros.Executar},
                {"Conversoes de Tipos", Conversao.Executar},
                {"Culture Info", ExemploCulture.Executar},
                {"ParseTexto", ParseTexto.Executar},
                {"Operadores", Operadores.Executar},
                {"Desvio Condicional", DesvioCondicional.Executar},
                {"While & DoWhile", WhileDoWhile.Executar},
                {"For e ForEach", ForForEach.Executar},
                {"Break e Continue", BreakContinue.Executar},
                {"Numero Randomico e Console Avancado", NumeroRandomicoConsoleAvancado.Executar},
            });

            central.SelecionarEExecutar();            
        }
    }
}