using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Arthur";
            pessoa.Idade = 20;

            // Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos");

            pessoa.ApresentarNoConsole();
            pessoa.Zerar();
            pessoa.ApresentarNoConsole();

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Beto";
            pessoa2.Idade = 21;

            var apresentacaoDaPessoa = pessoa2.Apresentar();
            Console.WriteLine(apresentacaoDaPessoa.Length);
            Console.WriteLine(apresentacaoDaPessoa);
        }
    }
}
