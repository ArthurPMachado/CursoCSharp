using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 23, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() { Nome = "Natalia", Idade = 25, Nota = 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 },
            };

            Console.WriteLine("** Aprovados *********");
            var aprovados = alunos.Where(item => item.Nota >= 7)
                                  .OrderBy(item => item.Nome);
            foreach(var item in aprovados) {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine("\n** Chamada ********");
            var chamada = alunos.OrderBy(item => item.Nome)
                                .Select(item => item.Nome);
            foreach(var item in chamada) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n** Aprovados (por Idade) ********");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var item in alunosAprovados) {
                Console.WriteLine(item);
            }
        }
    }
}
