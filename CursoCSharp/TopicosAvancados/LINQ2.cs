using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 23, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() { Nome = "Natalia", Idade = 25, Nota = 7.7 },
                new Aluno() { Nome = "Ana", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 },
            };

            var pedro = alunos.Single(item => item.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(item => item.Nome.Equals("Fulano"));
            if(fulano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(item => item.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nota}");

            var sicrano = alunos.FirstOrDefault(item => item.Nota.Equals("Sicrano"));
            if(sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(item => item.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(item => item.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(item => item.Nota);
            Console.WriteLine(menorNota);

            var somaNotas = alunos.Sum(item => item.Nota);
            Console.WriteLine(somaNotas);

            var mediaDaTurma = alunos.Average(item => item.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
