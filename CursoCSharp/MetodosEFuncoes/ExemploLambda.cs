using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            
            // Paradigma Funcional
            Func<int, string> conversorHex = numero => numero.ToString("X");

            // Paradigma OO
            /*
            public string ConversorHex(int numero) {
                return numero.ToString("X");
            }
            */

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format($"{dia:D2}/{mes:D2}/{ano:D4}");
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
