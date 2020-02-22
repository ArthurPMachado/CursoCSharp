using System;
using System.IO;

namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/Documents/Udemy/CSharp/CursoCSharp/CursoCSharp".ParseHome();

            if(Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if(Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("** Pastas **********");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var item in pastas) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n ** Arquivos *********");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var item in arquivos) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n ** Raiz **********");
            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
