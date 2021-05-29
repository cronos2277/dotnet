﻿using System;
using System.Collections.Generic;

namespace Fundamentos
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Ola Mundo - Fundamentos", Primeiro.Executar},
                {"Booleana e inferrência de tipos", Booleanos.Executar},
                {"Strings e Textos", Textos.Executar},
            });

            central.SelecionarEExecutar();            
        }
    }
}