using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach(var item in palavra) {
                Console.WriteLine(item);
            }

            var alunos = new string[] {"Ana", "Bia", "Carlos"};

            foreach(var item in alunos) {
                Console.WriteLine(item);
            }
        }
    }
}
