using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "MacBook";
            string marca = "Apple";
            double preco = 6000.00;

            Console.WriteLine("O " + nome 
                              + " da marca " 
                              + marca 
                              + " custa " 
                              + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", 
                              nome, marca, preco);
            Console.WriteLine($"A marca {marca} é cara");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
