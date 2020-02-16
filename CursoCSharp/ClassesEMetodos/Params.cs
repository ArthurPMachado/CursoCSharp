using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) {
            foreach(var item in pessoas) {
                Console.WriteLine($"Olá {item}");
            }
        }

        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");
        }
    }
}
