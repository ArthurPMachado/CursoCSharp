using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        public static int Soma(this int numero, int outroNumero) {
            return numero + outroNumero;
        }

        public static int Subtracao(this int numero, int outroNumero) {
            return numero - outroNumero;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }
    }
}
