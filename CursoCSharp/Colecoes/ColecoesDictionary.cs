using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if(filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008));
            }

            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}");

            foreach(var item in filmes.Keys) {
                Console.WriteLine(item);
            }

            foreach(var item in filmes.Values) {
                Console.WriteLine(item);
            }

            foreach(KeyValuePair<int, string> item in filmes) {
                Console.WriteLine($"{item.Value} é de {item.Key}.");
            }

            foreach(var item in filmes) {
                Console.WriteLine($"{item.Value} é de {item.Key}");
            }
        }
    }
}
