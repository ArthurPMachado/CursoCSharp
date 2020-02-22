using System;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProjeto = @"~/Documents/Udemy/CSharp/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("\n **Arquivos*************");
            var arquivos = dirInfo.GetFiles();
            foreach(var item in arquivos) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n ** Diretorios ********");
            var pastas = dirInfo.GetDirectories();
            foreach(var item in pastas) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
